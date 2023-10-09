#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ResumeBuilder.Web/*.csproj", "ResumeBuilder.Web/"]
COPY ["ResumeBuilder.Infrastructure/*.csproj", "ResumeBuilder.Infrastructure/"]
COPY ["ResumeBuilder.Application/*.csproj", "ResumeBuilder.Application/"]
COPY ["ResumeBuilder.Domain/*.csproj", "ResumeBuilder.Domain/"]
COPY ["ResumeBuilder.Persistence/*.csproj", "ResumeBuilder.Persistence/"]
RUN dotnet restore "ResumeBuilder.Web/ResumeBuilder.Web.csproj"
COPY . .
WORKDIR "/src/ResumeBuilder.Web"
RUN dotnet build "ResumeBuilder.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResumeBuilder.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResumeBuilder.Web.dll"]