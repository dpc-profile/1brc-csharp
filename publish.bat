rem dotnet publish -c Release --no-restore .\1brc\1brc.csproj

dotnet publish -c Release --self-contained .\1brc\1brc.csproj -f net6.0 -r win-x64 -o .\1brc\bin\Release\win-x64\
