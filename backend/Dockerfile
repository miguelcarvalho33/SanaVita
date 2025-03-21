# Base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY *.csproj ./
RUN dotnet restore

# Copy source code and publish
COPY . ./
RUN dotnet publish -c Release -o /publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /publish ./

# Expose the backend API port
EXPOSE 80

# Start the .NET app
ENTRYPOINT ["dotnet", "YourApp.dll"]

