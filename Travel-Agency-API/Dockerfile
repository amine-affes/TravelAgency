#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY ["Travel-Agency-API/Travel-Agency-API.csproj", "Travel-Agency-API/"]
RUN dotnet restore "Travel-Agency-API/Travel-Agency-API.csproj"
COPY . .
WORKDIR "/src/Travel-Agency-API"
RUN dotnet build "Travel-Agency-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Travel-Agency-API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Travel-Agency-API.dll"]