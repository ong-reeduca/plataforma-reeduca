FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Api.Reduca/Api.Reduca.csproj", "Api.Reduca/"]
RUN dotnet restore "Api.Reduca/Api.Reduca.csproj"
COPY . .
WORKDIR "/src/Api.Reduca"
RUN dotnet build "Api.Reduca.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Api.Reduca.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api.Reduca.dll"]