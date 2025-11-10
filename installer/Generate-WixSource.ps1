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

# Get installer directory
$installerDir = Split-Path -Parent $OutputPath

# Read the template
$template = Get-Content -Path "installer/Product.wxs.template" -Raw

# Basic replacements
$wxs = $template -replace '{{VERSION}}', $Version
$wxs = $wxs -replace '{{ICON_PATH}}', $IconPath
$wxs = $wxs -replace '{{PUBLISH_DIR}}', $PublishDir
$wxs = $wxs -replace '{{INSTALLER_DIR}}', $installerDir

# Get all files recursively (DLLs and native libraries)
$allFiles = Get-ChildItem -Path $PublishDir -Recurse -File
$dllComponents = ""
$index = 0

foreach ($file in $allFiles) {
    $relativePath = $file.FullName.Substring($PublishDir.Length + 1)
    $fileName = $file.Name
    
    # Skip the main DLL and EXE (already handled separately)
    if ($fileName -eq "GestionAgraria.dll" -or $fileName -eq "GestionAgraria.exe") {
        continue
    }
    
    # Skip already handled config files
    if ($fileName -eq "GestionAgraria.runtimeconfig.json" -or $fileName -eq "GestionAgraria.deps.json") {
        continue
    }
    
    # Create component for each file, preserving directory structure
    $safeId = "File_$index"
    $componentId = "Component_$index"
    
    $dllComponents += @"
      <Component Id="$componentId">
        <File Id="$safeId" Source="$PublishDir\$relativePath" />
      </Component>

"@
    $index++
}

# Replace template sections
$wxs = $wxs -replace '{{#each DLLS}}[\s\S]*?{{/each}}', $dllComponents

Write-Host "Processing $index files (including native libraries)"

# Check for appsettings.json
$hasAppSettings = Test-Path "$PublishDir\appsettings.json"
if ($hasAppSettings) {
    $appSettingsComponent = @"
      <Component Id="AppSettings">
        <File Id="AppSettingsJson" Source="$PublishDir\appsettings.json" />
      </Component>
"@
    $wxs = $wxs -replace '{{#if HAS_APPSETTINGS}}[\s\S]*?{{/if}}', $appSettingsComponent
} else {
    $wxs = $wxs -replace '{{#if HAS_APPSETTINGS}}[\s\S]*?{{/if}}', ''
}

# Save the generated file
$wxs | Out-File -FilePath $OutputPath -Encoding UTF8

Write-Host "✓ WiX source file generated successfully: $OutputPath"
Write-Host "✓ Total files included: $index"
Write-Host "✓ Template processed successfully"
