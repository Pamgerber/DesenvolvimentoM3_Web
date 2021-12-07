#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["apiLab/apiLab.csproj", "apiLab/"]
COPY ["Data/Data.csproj", "Data/"]
RUN dotnet restore "apiLab/apiLab.csproj"
COPY . .
WORKDIR "/src/apiLab"
RUN dotnet build "apiLab.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "apiLab.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "apiLab.dll"]