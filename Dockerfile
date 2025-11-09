# Use the official .NET SDK image to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set working directory
WORKDIR /app

# Copy all files from your GitHub repo (Jenkins workspace)
COPY . .

# Create a new console app and build your custom C# file inside it
RUN dotnet new console -n DieRollerApp --force \
    && rm DieRollerApp/Program.cs \
    && mv dieRoller.cs DieRollerApp/ \
    && cd DieRollerApp \
    && dotnet build -c Release

# Optional: Set the default command to run the app
CMD ["dotnet", "DieRollerApp/bin/Release/net8.0/DieRollerApp.dll"]
