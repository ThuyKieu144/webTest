# STAGE 1: Buildd
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

# Copy csproj và khôi phục dependencies
COPY . ./
RUN dotnet restore 

RUN dotnet publish -c Release -o publish

# STAGE 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/publish .
EXPOSE 8085
ENTRYPOINT ["dotnet", "ttxaphuong.dll"]
