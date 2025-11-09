# Use the official .NET SDK image to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy all files from Jenkins workspace to container
COPY . .

# Create the project and replace Program.cs with your own
RUN dotnet new console -n DieRollerApp --force \
    && rm DieRollerApp/Program.cs \
    && mv /app/dieRoller.cs /app/DieRollerApp/ \
    && cd /app/DieRollerApp \
    && dotnet build

# Set the default command to run the compiled app
CMD ["dotnet", "DieRollerApp/bin/Debug/net8.0/DieRollerApp.dll"]

