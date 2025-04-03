# Sử dụng image .NET SDK để xây dựng ứng dụng
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Sao chép file csproj và khôi phục các gói NuGet
COPY *.csproj ./
RUN dotnet restore

# Sao chép tất cả mã nguồn vào image
COPY . ./

# Xây dựng ứng dụng
RUN dotnet publish -c Release -o publish

# Sử dụng image .NET Runtime để chạy ứng dụng
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish ./

# Chỉ định lệnh khởi động ứng dụng
ENTRYPOINT ["dotnet", "ttxaphuong.dll"]
