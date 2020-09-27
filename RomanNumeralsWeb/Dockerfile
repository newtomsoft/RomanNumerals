#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["RomanNumeralsWeb/RomanNumeralsWeb.csproj", "RomanNumeralsWeb/"]
RUN dotnet restore "RomanNumeralsWeb/RomanNumeralsWeb.csproj"
COPY . .
WORKDIR "/src/RomanNumeralsWeb"
RUN dotnet build "RomanNumeralsWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RomanNumeralsWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RomanNumeralsWeb.dll"]