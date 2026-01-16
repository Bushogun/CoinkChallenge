FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY src ./src

WORKDIR /app/src/WebApplication1

RUN dotnet restore API.csproj
RUN dotnet publish API.csproj -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

EXPOSE 8080
ENTRYPOINT ["dotnet", "API.dll"]
