FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /s/l

COPY *.sln ./
COPY src/ ./src/
COPY tests/ ./tests/

RUN dotnet restore ./WaitFinish.sln 
RUN dotnet build --no-restore --configuration Release --verbosity minimal ./WaitFinish.sln 
RUN dotnet publish --no-restore --no-build --configuration Release --output /_destination/WaitFinish.Tests ./tests/WaitFinish.Tests/WaitFinish.Tests.csproj

FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /tests
COPY --from=build /_destination/WaitFinish.Tests /tests
CMD ["dotnet", "vstest", "WaitFinish.Tests.dll"]