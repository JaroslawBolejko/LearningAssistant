# LearningAssistant

LearningAssistant is a local educational assistant application built as a personal learning project.

The goal of the application is to help organize and review knowledge from different areas, including .NET/C#, Docker, MongoDB, Azure, SQL, social economy topics such as OWES, and interview preparation.

## Current status

The project is in an early development stage.

Currently implemented:

- Blazor Web App with Interactive Server
- ASP.NET Core API Controllers
- SQLite integration through Entity Framework Core
- basic learning material model
- basic API for creating and reading learning materials
- global exception handling middleware
- health check endpoint

Not implemented yet:

- OpenAI API integration
- quiz generation
- learning history
- document import
- RAG
- embeddings
- local knowledge indexing
- final UI for daily use

## Technologies

- .NET
- Blazor Web App
- ASP.NET Core
- Entity Framework Core
- SQLite

## Running locally

```bash
dotnet restore
dotnet build
dotnet run
