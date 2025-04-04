# STAGE 1: Buildd
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj và khôi phục dependencies
COPY webApp/*.csproj ./webApp/
RUN dotnet restore "webApp/webApp.csproj"

# Copy toàn bộ source code và build
COPY webApp/ ./webApp/
WORKDIR /src/webApp
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# STAGE 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "webApp.dll"]
