# Script para generar el archivo Product.wxs desde el template
param(
    [Parameter(Mandatory=$true)]
    [string]$Version,
    
    [Parameter(Mandatory=$true)]
    [string]$PublishDir,
    
    [Parameter(Mandatory=$true)]
    [string]$IconPath,
    
    [Parameter(Mandatory=$true)]
    [string]$OutputPath
)

Write-Host "Generating WiX source file..."
Write-Host "Version: $Version"
Write-Host "Publish Directory: $PublishDir"
Write-Host "Icon Path: $IconPath"

# Read the template
$template = Get-Content -Path "installer/Product.wxs.template" -Raw

# Basic replacements
$wxs = $template -replace '{{VERSION}}', $Version
$wxs = $wxs -replace '{{ICON_PATH}}', $IconPath
$wxs = $wxs -replace '{{PUBLISH_DIR}}', $PublishDir

# Get all DLL files
$dllFiles = Get-ChildItem -Path $PublishDir -Filter "*.dll" | Select-Object -ExpandProperty Name

# Generate DLL components (simplified version)
$dllComponents = ""
$index = 0
foreach ($dll in $dllFiles) {
    if ($dll -ne "GestionAgraria.dll") {
        $dllComponents += @"
      <Component Id="DLL_$index" Guid="*">
        <File Id="File_$index" Source="$PublishDir\$dll" KeyPath="yes" />
      </Component>

"@
        $index++
    }
}

# Replace template sections
$wxs = $wxs -replace '{{#each DLLS}}[\s\S]*?{{/each}}', $dllComponents

# Check for appsettings.json
$hasAppSettings = Test-Path "$PublishDir\appsettings.json"
if ($hasAppSettings) {
    $appSettingsComponent = @"
      <Component Id="AppSettings" Guid="*">
        <File Id="AppSettingsJson" Source="$PublishDir\appsettings.json" KeyPath="yes" />
      </Component>
"@
    $wxs = $wxs -replace '{{#if HAS_APPSETTINGS}}[\s\S]*?{{/if}}', $appSettingsComponent
} else {
    $wxs = $wxs -replace '{{#if HAS_APPSETTINGS}}[\s\S]*?{{/if}}', ''
}

# Save the generated file
$wxs | Out-File -FilePath $OutputPath -Encoding UTF8

Write-Host "WiX source file generated successfully: $OutputPath"
Write-Host "Found $index DLL files"
