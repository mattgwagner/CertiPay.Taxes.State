$BaseDir = Split-Path (Resolve-Path $MyInvocation.MyCommand.Path)

mkdir "$BaseDir\Artifacts" -Force

& "$BaseDir\.NuGet\NuGet.exe" Pack CertiPay.Taxes.State\CertiPay.Taxes.State.nuspec -Properties Configuration=Release -OutputDirectory "$BaseDir\artifacts\"