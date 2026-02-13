# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy csproj from subfolder
COPY IndiaStatesAPI/*.csproj IndiaStatesAPI/
RUN dotnet restore IndiaStatesAPI/IndiaStatesAPI.csproj

# copy everything
COPY . .
WORKDIR /src/IndiaStatesAPI

RUN dotnet publish -c Release -o /app/publish

# ---------- Runtime stage ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "IndiaStatesAPI.dll"]
