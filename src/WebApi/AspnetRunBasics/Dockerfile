#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/WebApi/AspnetRunBasics/AspnetRunBasics.csproj", "src/WebApi/AspnetRunBasics/"]
RUN dotnet restore "src/WebApi/AspnetRunBasics/AspnetRunBasics.csproj"
COPY . .
WORKDIR "/src/src/WebApi/AspnetRunBasics"
RUN dotnet build "AspnetRunBasics.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspnetRunBasics.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspnetRunBasics.dll"]
