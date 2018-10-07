FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY DockerMVC/DockerMVC.csproj DockerMVC/
RUN dotnet restore DockerMVC/DockerMVC.csproj
COPY . .
WORKDIR /src/DockerMVC
RUN dotnet build DockerMVC.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DockerMVC.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerMVC.dll"]
