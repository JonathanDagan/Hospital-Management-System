# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
# COPY *.csproj ./
COPY . .

RUN dotnet restore

ENTRYPOINT ["dotnet", "run", "--project", "UI/UI.csproj"]