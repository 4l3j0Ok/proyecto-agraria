# Script para probar el proceso completo de generación del instalador localmente
# Ejecutar desde la raíz del proyecto

param(
    [Parameter(Mandatory=$false)]
    [string]$Version = "1.0.0-local",
    
    [Parameter(Mandatory=$false)]
    [switch]$SkipBuild,
    
    [Parameter(Mandatory=$false)]
    [switch]$SkipTest
)

$ErrorActionPreference = "Stop"

Write-Host "=====================================" -ForegroundColor Cyan
Write-Host "  Test Local del Instalador MSI" -ForegroundColor Cyan
Write-Host "=====================================" -ForegroundColor Cyan
Write-Host ""

# Paths
$projectRoot = $PSScriptRoot
$srcDir = Join-Path $projectRoot "src"
$publishDir = Join-Path $projectRoot "publish"
$installerDir = Join-Path $projectRoot "installer"
$iconPath = Join-Path $srcDir "Views\Assets\Icons\Icon.ico"

# Step 1: Limpiar directorios anteriores
Write-Host "[1/6] Limpiando directorios previos..." -ForegroundColor Yellow
if (Test-Path $publishDir) {
    Remove-Item -Path $publishDir -Recurse -Force
    Write-Host "  ✓ Directorio publish limpiado" -ForegroundColor Green
}

$oldWxs = Join-Path $installerDir "Product.wxs"
if (Test-Path $oldWxs) {
    Remove-Item -Path $oldWxs -Force
    Write-Host "  ✓ Product.wxs anterior eliminado" -ForegroundColor Green
}

$oldMsi = Get-ChildItem -Path $installerDir -Filter "*.msi" -ErrorAction SilentlyContinue
if ($oldMsi) {
    $oldMsi | ForEach-Object { Remove-Item $_.FullName -Force }
    Write-Host "  ✓ MSI anteriores eliminados" -ForegroundColor Green
}

Write-Host ""

# Step 2: Verificar prerrequisitos
Write-Host "[2/6] Verificando prerrequisitos..." -ForegroundColor Yellow

# Verificar .NET
try {
    $dotnetVersion = & dotnet --version
    Write-Host "  ✓ .NET SDK: $dotnetVersion" -ForegroundColor Green
} catch {
    Write-Host "  ✗ .NET SDK no encontrado. Instalar desde https://dotnet.microsoft.com/" -ForegroundColor Red
    exit 1
}

# Verificar WiX
try {
    $wixVersion = & wix --version
    Write-Host "  ✓ WiX Toolset: $wixVersion" -ForegroundColor Green
} catch {
    Write-Host "  ✗ WiX Toolset no encontrado. Instalando..." -ForegroundColor Yellow
    & dotnet tool install --global wix --version 5.0.2
    Write-Host "  ✓ WiX Toolset instalado" -ForegroundColor Green
}

# Verificar icono
if (-not (Test-Path $iconPath)) {
    Write-Host "  ✗ Icono no encontrado en: $iconPath" -ForegroundColor Red
    exit 1
} else {
    Write-Host "  ✓ Icono encontrado" -ForegroundColor Green
}

Write-Host ""

# Step 3: Build y Publish
if (-not $SkipBuild) {
    Write-Host "[3/6] Compilando y publicando aplicación..." -ForegroundColor Yellow
    
    try {
        # Restore
        Write-Host "  - Restaurando dependencias..." -ForegroundColor Gray
        & dotnet restore "$srcDir\GestionAgraria.sln" | Out-Null
        
        # Build
        Write-Host "  - Compilando solución..." -ForegroundColor Gray
        & dotnet build "$srcDir\GestionAgraria.sln" --configuration Release --no-restore
        if ($LASTEXITCODE -ne 0) { throw "Build falló" }
        
        # Publish
        Write-Host "  - Publicando aplicación..." -ForegroundColor Gray
        & dotnet publish "$srcDir\GestionAgraria.csproj" `
            --configuration Release `
            --no-build `
            --output $publishDir `
            --self-contained false
        if ($LASTEXITCODE -ne 0) { throw "Publish falló" }
        
        $publishedFiles = Get-ChildItem -Path $publishDir -File | Measure-Object
        Write-Host "  ✓ Aplicación publicada ($($publishedFiles.Count) archivos)" -ForegroundColor Green
    } catch {
        Write-Host "  ✗ Error durante build/publish: $_" -ForegroundColor Red
        exit 1
    }
} else {
    Write-Host "[3/6] Build omitido (--SkipBuild)" -ForegroundColor Gray
}

Write-Host ""

# Step 4: Generar Product.wxs
Write-Host "[4/6] Generando archivo WiX..." -ForegroundColor Yellow

try {
    $generateScript = Join-Path $installerDir "Generate-WixSource.ps1"
    $outputWxs = Join-Path $installerDir "Product.wxs"
    
    & $generateScript `
        -Version $Version `
        -PublishDir $publishDir `
        -IconPath $iconPath `
        -OutputPath $outputWxs
    
    if (-not (Test-Path $outputWxs)) {
        throw "No se generó Product.wxs"
    }
    
    $wxsSize = (Get-Item $outputWxs).Length / 1KB
    Write-Host "  ✓ Product.wxs generado ($([math]::Round($wxsSize, 2)) KB)" -ForegroundColor Green
} catch {
    Write-Host "  ✗ Error generando WiX: $_" -ForegroundColor Red
    exit 1
}

Write-Host ""

# Step 5: Compilar MSI
Write-Host "[5/6] Compilando instalador MSI..." -ForegroundColor Yellow

try {
    Push-Location $installerDir
    
    $msiName = "GestionAgraria-$Version.msi"
    
    & wix build Product.wxs `
        -out $msiName `
        -ext WixToolset.UI.wixext `
        -arch x64
    
    Pop-Location
    
    $msiPath = Join-Path $installerDir $msiName
    
    if (-not (Test-Path $msiPath)) {
        throw "No se generó el MSI"
    }
    
    $msiSize = (Get-Item $msiPath).Length / 1MB
    Write-Host "  ✓ MSI compilado: $msiName ($([math]::Round($msiSize, 2)) MB)" -ForegroundColor Green
} catch {
    Pop-Location
    Write-Host "  ✗ Error compilando MSI: $_" -ForegroundColor Red
    exit 1
}

Write-Host ""

# Step 6: Test (opcional)
if (-not $SkipTest) {
    Write-Host "[6/6] Probando instalador..." -ForegroundColor Yellow
    
    # Verificar propiedades del MSI
    try {
        $msi = Get-ItemProperty $msiPath
        Write-Host "  ✓ Archivo: $($msi.Name)" -ForegroundColor Green
        Write-Host "  ✓ Tamaño: $([math]::Round($msi.Length / 1MB, 2)) MB" -ForegroundColor Green
        Write-Host "  ✓ Ubicación: $($msi.FullName)" -ForegroundColor Green
        
        # Preguntar si desea instalar
        Write-Host ""
        $install = Read-Host "¿Deseas probar la instalación? (s/N)"
        
        if ($install -eq "s" -or $install -eq "S") {
            Write-Host "  Instalando... (requiere permisos de administrador)" -ForegroundColor Yellow
            $logFile = Join-Path $installerDir "test-install.log"
            
            Start-Process msiexec.exe -ArgumentList "/i `"$msiPath`" /l*v `"$logFile`"" -Wait -Verb RunAs
            
            Write-Host "  ✓ Instalación completada" -ForegroundColor Green
            Write-Host "  Log guardado en: $logFile" -ForegroundColor Gray
        }
    } catch {
        Write-Host "  ✗ Error probando MSI: $_" -ForegroundColor Red
    }
} else {
    Write-Host "[6/6] Tests omitidos (--SkipTest)" -ForegroundColor Gray
}

Write-Host ""
Write-Host "=====================================" -ForegroundColor Cyan
Write-Host "  ✓ Proceso completado exitosamente" -ForegroundColor Green
Write-Host "=====================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "Instalador generado en:" -ForegroundColor White
Write-Host "  $msiPath" -ForegroundColor Cyan
Write-Host ""
