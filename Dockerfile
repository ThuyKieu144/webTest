# STAGE 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
EXPOSE 8080  

# Copy toàn bộ nội dung vào container
COPY . ./

# Restore dependencies
RUN dotnet restore "ttxaphuong/ttxaphuong.csproj"
#
#
# ❗ Cài dotnet ef tool
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

# ❗ Chạy database update (migration)
# ⚠️ Nhớ đảm bảo ConnectionString đúng trong appsettings.json hoặc appsettings.Production.json
RUN dotnet ef database update --project ttxaphuong/ttxaphuong.csproj
#
#

# Build
RUN dotnet build "ttxaphuong/ttxaphuong.csproj" -c Release -o /app/build

# Publish
RUN dotnet publish "ttxaphuong/ttxaphuong.csproj" -c Release -o /app/publish /p:UseAppHost=false

# STAGE 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish ./
ENTRYPOINT ["dotnet", "ttxaphuong.dll"]
