FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY api/PYWalkingApp/*.csproj api/PYWalkingApp/
RUN dotnet restore api/PYWalkingApp/PYWalkingApp.csproj

# copy everything else and publish
COPY . .
WORKDIR /src/api/PYWalkingApp
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "PYWalkingApp.dll"]
