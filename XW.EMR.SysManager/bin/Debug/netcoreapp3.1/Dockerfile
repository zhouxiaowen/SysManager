#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["XW.EMR.SysManager/XW.EMR.SysManager.csproj", "XW.EMR.SysManager/"]
#RUN dotnet restore "XW.EMR.SysManager/XW.EMR.SysManager.csproj"
#COPY . .
#WORKDIR "/src/XW.EMR.SysManager"
#RUN dotnet build "XW.EMR.SysManager.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "XW.EMR.SysManager.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "XW.EMR.SysManager.dll"]


FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /app
ARG BUILD_CONFIGURATION=Debug
ENV ASPNETCORE_ENVIRONMENT=Development
ENV DOTNET_USE_POLLING_FILE_WATCHER=true  
ENV ASPNETCORE_URLS=http://+:80  
EXPOSE 80
COPY . .
ENTRYPOINT ["dotnet", "XW.EMR.SysManager.Services.dll"]