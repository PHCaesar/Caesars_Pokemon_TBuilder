#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Caesars_Pokemon_TBuilder/Caesars_Pokemon_TBuilder.csproj", "Caesars_Pokemon_TBuilder/"]
RUN dotnet restore "Caesars_Pokemon_TBuilder/Caesars_Pokemon_TBuilder.csproj"
COPY . .
WORKDIR "/src/Caesars_Pokemon_TBuilder"
RUN dotnet build "Caesars_Pokemon_TBuilder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Caesars_Pokemon_TBuilder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Caesars_Pokemon_TBuilder.dll"]