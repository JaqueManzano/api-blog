FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copiar arquivos necessários e restaurar dependências
COPY *.csproj .
RUN dotnet restore

# Copiar todo o conteúdo do projeto e compilar
COPY . .
RUN dotnet publish -c Release -o out

# Build da imagem de publicação
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "NomeDoSeuProjeto.dll"]
