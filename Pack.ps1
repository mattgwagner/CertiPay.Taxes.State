param (
	[string]$Configuration = 'Debug'
)

$ErrorActionPreference = "Stop"

$Here = "$(Split-Path -parent $MyInvocation.MyCommand.Definition)"

$Output = Join-Path $Here "artifacts"

$DotNet = "${env:ProgramFiles}\dotnet\dotnet.exe"

& $DotNet pack "CertiPay.Taxes.State" --configuration $Configuration --output $Output

EXIT $LASTEXITCODE