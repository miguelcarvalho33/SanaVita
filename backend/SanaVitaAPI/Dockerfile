# Etapa 1 - Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar ficheiros de projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar restante código-fonte e compilar
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Etapa 2 - Runtime final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar a app compilada da etapa de build
COPY --from=build /app/publish ./

# Expor a porta usada pela app
EXPOSE 80

# Comando de arranque da app
ENTRYPOINT ["dotnet", "SanaVitaAPI.dll"]
