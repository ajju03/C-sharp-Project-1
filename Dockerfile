# Use the official .NET SDK image to build and run
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set working directory
WORKDIR /app

# Copy your C# source file into the container
COPY dieRoller.cs .

# Create a minimal project file dynamically
RUN dotnet new console --force \
    && rm Program.cs \
    && mv dieRoller.cs Program.cs \
    && dotnet build -c Release

# Run the compiled app
CMD ["dotnet", "run", "--configuration", "Release"]
