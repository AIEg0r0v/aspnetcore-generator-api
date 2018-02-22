#integration
FROM microsoft/dotnet:2-sdk 
WORKDIR /integration

COPY integration.csproj .
RUN dotnet restore

COPY . . 
# Runtime Image Stage
ENTRYPOINT ["dotnet", "test"]