FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish helloworld.csproj \
    --configuration Release \
    --output /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime
COPY --from=build-env /app /app
WORKDIR /app
ENTRYPOINT ["dotnet", "helloworld.dll"]
