FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /test

COPY bin/Release/netcoreapp3.1/publish/ /test

ENTRYPOINT [ "dotnet", "test.dll"]
