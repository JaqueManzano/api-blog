FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copiar arquivos necess�rios e restaurar depend�ncias
COPY *.csproj .
RUN dotnet restore

# Copiar todo o conte�do do projeto e compilar
COPY . .
RUN dotnet publish -c Release -o out

# Build da imagem de publica��o
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "NomeDoSeuProjeto.dll"]
