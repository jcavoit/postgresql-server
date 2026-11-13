# PostgreSqlServer

A small REST API built with ASP.NET Core (.NET 10) and Entity Framework Core to learn how to build a web service that stores data in a database.

> **Status:** early-stage learning project. The repository is named `postgresql-server` because the goal is to move to PostgreSQL, but the current version stores data in **SQLite**.

## Features

- REST API for managing cars (`Car` with `Id` and `Name`).
- Entity Framework Core with a `DbContext` (`MyDatabase`).
- Database file created automatically on startup (`EnsureCreated`).
- OpenAPI document exposed in the Development environment.
- HTTPS redirection enabled.

## Tech Stack

| Area | Technology |
|---|---|
| Language / runtime | C# / .NET 10 |
| Framework | ASP.NET Core Web API (controllers) |
| ORM | Entity Framework Core 10 |
| Database (current) | SQLite (`coches.db`) |
| API docs | Microsoft.AspNetCore.OpenApi |

## Project Structure

```text
servidor/
├── PostgreSqlServer.slnx
└── PostgreSqlServer/
    ├── Controllers/
    │   └── CarsController.cs
    ├── Database/
    │   ├── MyDatabase.cs
    │   └── Entities/Car.cs
    ├── Program.cs
    ├── appsettings.json
    └── PostgreSqlServer.http
```

## API Endpoints

Base route: `/api/cars`

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/cars` | List all cars |
| GET | `/api/cars/{id}` | Get a car by id |
| GET | `/api/cars/byname/{name}` | Search cars whose name contains the text (case-insensitive) |
| POST | `/api/cars` | Create a car |

Example request body for `POST /api/cars`:

```json
{
  "name": "Seat Ibiza"
}
```

## Getting Started

### Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)


## Roadmap

- [ ] Add `PUT` and `DELETE` endpoints (a `DELETE` draft is currently commented out).
- [ ] Migrate from SQLite to PostgreSQL (Npgsql provider).
- [ ] Move the connection string to configuration / environment variables.
- [ ] Replace `EnsureCreated` with EF Core migrations.
- [ ] Add input validation and error responses (e.g. `404` when a car does not exist).
- [ ] Run PostgreSQL and the API with Docker Compose.

## About

Personal project by an ASIR student learning backend development and databases as part of a path towards systems administration, cloud and cybersecurity.
