param (
	## The build target, i.e. Build, Rebuild, Clean
	[string]$Target = 'Build',

	## The build configuration, i.e. Debug/Release
	[string]$Configuration = 'Debug'
)

$ErrorActionPreference = "Stop"

$Here = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"

$SolutionFile = Join-Path $Here "CertiPay.Taxes.State.sln"

# Bootstap ensures we have what we need to build the project

$DotNet = "${env:ProgramFiles}\dotnet\dotnet.exe"

# Build the solution, packaging the files if requested

Write-Output "Running build target $Target for $Configuration"

& $DotNet build $SolutionFile /t:$Target /m /p:Configuration=$Configuration

EXIT $LASTEXITCODE