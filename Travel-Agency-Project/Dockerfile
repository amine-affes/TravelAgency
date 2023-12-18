#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview AS build
WORKDIR /src
COPY ["Travel-Agency-Project/Travel-Agency-Project.csproj", "Travel-Agency-Project/"]
RUN dotnet restore "Travel-Agency-Project/Travel-Agency-Project.csproj"
COPY . .
WORKDIR "/src/Travel-Agency-Project"
RUN dotnet build "Travel-Agency-Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Travel-Agency-Project.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Travel-Agency-Project.dll"]