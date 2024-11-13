
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY Back/*.csproj ./
RUN dotnet restore

COPY Back/. ./
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

EXPOSE 80
EXPOSE 5000

ENTRYPOINT ["dotnet", "Back.dll"]