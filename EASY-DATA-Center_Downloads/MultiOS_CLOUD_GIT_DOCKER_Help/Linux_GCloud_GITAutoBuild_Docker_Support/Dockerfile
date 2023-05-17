#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SHOPINGER.csproj", "."]
RUN dotnet restore "./SHOPINGER.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SHOPINGER.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SHOPINGER.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 80 443 5000
#ENV ASPNETCORE_URLS=http://*:5000

ENTRYPOINT ["dotnet", "SHOPINGER.dll"]