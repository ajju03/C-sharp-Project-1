# Use official .NET SDK image to build and run C#
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set working directory
WORKDIR /app

# Copy your source code into container
COPY . .

# Compile your C# code
RUN dotnet new console -n DieRollerApp --force && \
    rm DieRollerApp/Program.cs && \
    mv dieRoller.cs DieRollerApp/ && \
    cd DieRollerApp && dotnet build

# Set the default command to run the compiled app
CMD ["dotnet", "DieRollerApp/bin/Debug/net8.0/DieRollerApp.dll"]

