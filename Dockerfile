FROM mcr.microsoft.com/dotnet/core/sdk:3.1
COPY SOTpFinal.sln /app/

COPY SOTpFinal /app/

WORKDIR /app

RUN dotnet publish -c Release -o dist SOTpFinal.csproj

#ENTRYPOINT ["dotnet", "dist/SOTpFinal.dll"]


