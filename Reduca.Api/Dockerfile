FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Reduca.Api/Reduca.Api.csproj", "Reduca.Api/"]
RUN dotnet restore "Reduca.Api/Reduca.Api.csproj"
COPY . .
WORKDIR "/src/Reduca.Api"
RUN dotnet build "Reduca.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Reduca.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Reduca.Api.dll"]