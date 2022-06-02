FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/SimpleToDo.API/SimpleToDo.API.csproj", "SimpleToDo.API/"]
RUN dotnet restore "src/SimpleToDo.API/SimpleToDo.API.csproj"
COPY . .
WORKDIR "/src/SimpleToDo.API"
RUN dotnet build "SimpleToDo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleToDo.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleToDo.API.dll"]
