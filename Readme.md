# Damage App

A multi-project .NET solution simulating a warrior combat system. Built as a learning project covering REST APIs, Entity Framework Core, a shared class library, and a React frontend.

## Projects

### DamageAPI
ASP.NET Core Web API backed by Entity Framework Core and MS SQL Server.

**Endpoints:**
| Method | Route | Description |
|--------|-------|-------------|
| POST | `api/warrior/add` | Create a new warrior |
| GET  | `api/warrior/{id}` | Get a warrior by ID |
| PUT  | `api/damage/{warriorId}/{damage}` | Apply damage to a warrior |
| DELETE | `api/warrior/{id}` | Delete a warrior |

### damageui
React + Vite frontend for interacting with the API. Supports spawning, creating, damaging, and deleting warriors.

### DamageConsoleApp
A console client that interacts with the API via HttpClient.

### Models
Shared class library referenced by both API and console app, containing the `Warrior` model.

## Tech Stack

- C# / .NET 10
- ASP.NET Core Web API
- Entity Framework Core with MS SQL Server
- React + Vite
- GitHub Actions (self-hosted runner) for CI/CD

## Getting Started

### Prerequisites
- .NET 10 SDK
- MS SQL Server
- Node.js
- Visual Studio 2022 or later

### Setup

1. Clone the repository
```bash
git clone https://github.com/RealArbitrary/Damage.git
```

2. Configure appsettings:
- `appsettings.Development.json` for local dev
- `appsettings.Production.json` for the server

Both use:
```json
"ConnectionStrings": {
    "DamageAPI": "Server=localhost;Database=DamageAPI;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

3. Apply migrations:
```bash
cd DamageAPI
dotnet ef database update
```

4. Run the API:
```bash
dotnet run --launch-profile http
```

5. Build and serve the frontend:
```bash
cd damageui
npm install
npm run build
npx serve dist
```

## Deployment

The app is self-hosted on a local Windows machine using:
- **NSSM** to run the API and React app as Windows services
- **GitHub Actions** with a self-hosted runner on the server
- Merging to `master` automatically pulls, rebuilds, and restarts both services
