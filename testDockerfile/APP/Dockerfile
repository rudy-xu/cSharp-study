FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /APP

COPY bin/Release/netcoreapp3.1/publish/ /APP

ENTRYPOINT [ "dotnet", "NetCore.Docker.dll"]
