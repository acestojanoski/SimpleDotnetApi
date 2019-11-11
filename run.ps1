Write-Host
Write-Host "######################"
Write-Host "Restoring packages..."
Write-Host "######################"

dotnet restore

Write-Host
Write-Host "######################"
Write-Host "Building solution..."
Write-Host "######################"

dotnet build

Write-Host
Write-Host "##################################"
Write-Host "Running SimpleDotnetApi project..."
Write-Host "##################################"

dotnet run -p SimpleDotnetApi
