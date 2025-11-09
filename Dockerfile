# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /app

# Copy your app source from Jenkins workspace
COPY DieRollerApp/ .

# Build and run
RUN dotnet build -c Release

CMD ["dotnet", "run", "--configuration", "Release"]
