# Damage App

A multi-project .NET solution simulating a warrior combat system. Built as a learning project covering REST APIs, Entity Framework Core, shared class libraries, and console-based client interaction.

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
| GET | `/{id}` | Get a warrior by ID |
| PUT | `/{warriorId}/{damage}` | Apply damage to a warrior |

### DamageConsoleApp
A console client that interacts with the API. Handles user input validation and displays warrior details retrieved from the API.

### Models
A shared class library referenced by both projects, containing the `Warrior` model to ensure consistency across the solution.

## Tech Stack

- **C#** / **.NET**
- **ASP.NET Core** Web API
- **Entity Framework Core** with MS SQL Server
- **HttpClient** for API consumption

## Getting Started

### Prerequisites
- .NET 8 SDK
- MS SQL Server
- Visual Studio 2022 or later

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

## Planned
- Create and delete warrior endpoints
- Web frontend with HTMX
- Azure hosting
- Authentication