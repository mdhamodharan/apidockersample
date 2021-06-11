#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ApiDockerSample1/ApiDockerSample1.csproj", "ApiDockerSample1/"]
RUN dotnet restore "ApiDockerSample1/ApiDockerSample1.csproj"
COPY . .
WORKDIR "/src/ApiDockerSample1"
RUN dotnet build "ApiDockerSample1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiDockerSample1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiDockerSample1.dll"]