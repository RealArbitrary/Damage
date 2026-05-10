# Damage App

A multi-project .NET solution simulating a warrior combat system. Built as a learning project covering REST APIs, Entity Framework Core, a shared class library, and a console-based client.

## Solution Structure

```
Damage/
├── DamageAPI/          # ASP.NET Core Web API
├── DamageConsoleApp/   # Console client
└── Models/             # Shared class library (Warrior model)
```

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

### DamageConsoleApp
A console client that interacts with the API. It displays a simple menu for creating, spawning, damaging, and deleting warriors and uses HttpClient to call the API.

### Models
A shared class library referenced by both projects, containing the `Warrior` model to ensure consistency across the solution.

## Tech Stack

- C# / .NET 10
- ASP.NET Core Web API
- Entity Framework Core with MS SQL Server
- HttpClient for API consumption

## Getting Started

### Prerequisites
- .NET 10 SDK
- MS SQL Server
- Visual Studio 2022 or later (Visual Studio 2026 is also supported)

### Setup

1. Clone the repository
```bash
git clone https://github.com/RealArbitrary/Damage.git
```

2. Update the connection string in `DamageAPI/appsettings.json`:
```json
"ConnectionStrings": {
    "DefaultConnection": "your-connection-string-here"
}
```

3. Apply migrations:
```bash
cd DamageAPI
dotnet ef database update
```

4. Run the API project first, then the console app.

## Notes
- Create and delete warrior endpoints have been implemented in the API (POST `api/warrior/add`, DELETE `api/warrior/{id}`).

## Planned
- Web frontend with HTMX
- Azure hosting
- Authentication
