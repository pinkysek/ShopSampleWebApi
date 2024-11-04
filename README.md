# ShopSampleWebApi

ShopSampleWebApi is a REST API application built with **ASP.NET Core Web API** (latest LTS version .NET 8.0). The project uses **Entity Framework Core** with **Microsoft SQL Server** as the database backend. It follows **layered architecture** and **SOLID design principles**.

## Project Structure

The application is organized into several projects to ensure separation of concerns:

- **ShopSampleWebApi** - Presentation Layer (Web API).
- **ShopSampleWebApi.Core** - Business Logic Layer (BLL).
- **ShopSampleWebApi.DataAccess** - Data Access Layer (DAL).
- **ShopSampleWebApi.DataAccess.Tests** - Unit tests for the Data Access Layer.
- **ShopSampleWebApi.WebApi.Tests** - Unit tests for the Web API.

## Functionality

The API provides two versions of endpoints for managing products:

### Product API v1

- **GET /api/v1/product/id/{id}** - Retrieve a product by ID.
- **GET /api/v1/product** - Retrieve all products.
- **PATCH /api/v1/product/id/{id}/description** - Partially update a product (description).

### Product API v2

- **GET /api/v2/product/id/{id}** - Retrieve a product by ID.
- **GET /api/v2/product** - Retrieve all products with pagination.
- **PATCH /api/v2/product/id/{id}/description** - Partially update a product (description).

### API Documentation

The Swagger documentation is available at `/swagger` after starting the application. It provides detailed information about all available endpoints.

## Configuration

The application settings are configured through `appsettings.json` or `appsettings.Development.json` based on the environment (Production or Development). In the `DatabaseSettings` section, you can define the database type (`DatabaseType`) as either **InMemory** or **Real**. For the **Real** database type, set up the database connection string (`RealDatabaseConnectionString`). A default connection string for a local MSSQL DB is provided:

`Server=(localdb)\mssqllocaldb;Database=ProductDb;Trusted_Connection=True;`

Adjust this as needed for other database locations.

Both the **InMemory** and **Real** database types come with an initial seed of 100 sample products.

## Prerequisites

- **IDE**: Visual Studio or a similar IDE
- **Database**: For the `InMemory` database type, no external SQL server is required. For the `Real` type, Microsoft SQL Server is required.

## Unit Testing

The unit tests use the same configuration as the application, allowing you to set the database type to either **InMemory** or **Real** in `appsettings.json.`

## Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/ShopSampleWebApi.git
   ```

2. **Open in Visual Studio** or your preferred IDE.

3. **Configure Database**:
   - Set `DatabaseType` to `InMemory` or `Real` in `appsettings.json`.
   - If using `Real`, verify or update the `RealDatabaseConnectionString`.

4. **Run Database Migrations** (for `Real` database type):
   ```bash
   dotnet ef database update
   ```

5. **Run the application**:
   ```bash
   dotnet run
   ```

6. **Access Swagger** at [http://localhost:5000/swagger](http://localhost:5000/swagger).

## Running Tests

To run unit tests:

```bash
dotnet test
```

---
