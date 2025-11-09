# 🎲 Die Roller App

A simple **C# console application** that simulates a dice rolling game — built with **.NET 8** and containerized using **Docker**.

---

## 🧠 About the Project

This project is a fun CLI-based dice game where:

- You roll a die against the system.
- The player who rolls the higher number wins the round.
- Win at least 2 out of 3 rounds to win the game!

The app runs completely inside a Docker container using the official .NET SDK image.

---

## 🏗️ Technologies Used

- **C# / .NET 8**
- **Docker**
- **Linux-based container**

---

## 📂 Project Structure


### 🧱 Dockerfile Overview

The Dockerfile automates the build and run process for the app:

```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY . .

RUN dotnet new console -n DieRollerApp --force && \
    rm DieRollerApp/Program.cs && \
    mv dieRoller.cs DieRollerApp/ && \
    cd DieRollerApp && dotnet build

CMD ["dotnet", "DieRollerApp/bin/Debug/net8.0/DieRollerApp.dll"]

**How to Build and Run
Step 1 — Build the Docker image**
