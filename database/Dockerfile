# Base image: Microsoft SQL Server
FROM mcr.microsoft.com/mssql/server:2022-latest

# Set environment variables (customize password & configs)
ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=YourStrongPassword123

# Expose SQL Server port
EXPOSE 1433

# Start SQL Server
CMD ["/opt/mssql/bin/sqlservr"]

