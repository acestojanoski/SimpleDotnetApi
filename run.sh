#!/bin/bash

echo
echo "######################"
echo "Restoring packages..."
echo "######################"

dotnet restore

echo
echo "######################"
echo "Building solution..."
echo "######################"

dotnet build

echo
echo "##################################"
echo "Running SimpleDotnetApi project..."
echo "##################################"

dotnet run -p SimpleDotnetApi
