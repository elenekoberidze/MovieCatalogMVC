# 🎬 Movie Catalog — ASP.NET Core MVC CRUD App
 
A simple **movie catalog web app**, built with **ASP.NET Core MVC** and **Entity Framework Core**, to practice classic server-rendered CRUD (Create, Read, Update, Delete) patterns with Razor Views and a SQL Server database.
 
<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white">
  <img alt="ASP.NET Core MVC" src="https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white">
  <img alt="EF Core" src="https://img.shields.io/badge/EF%20Core-8.0-512BD4?logo=dotnet&logoColor=white">
  <img alt="SQL Server" src="https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white">
  <img alt="Bootstrap" src="https://img.shields.io/badge/Bootstrap-5-7952B3?logo=bootstrap&logoColor=white">
  <img alt="License" src="https://img.shields.io/badge/license-MIT-green">
</p>
---
 
## 📖 Overview
 
**MovieProject** (internally named `Imdb_418`) is a small, IMDb-style web app for managing a list of movies. It lets you add, view, edit, and delete movie entries — each with a title, description, release date, and genre — through a clean server-rendered UI built with Razor Views and Bootstrap.
 
This was built as a **practice project** to work through the fundamentals of ASP.NET Core MVC: controllers, Razor views, model binding/validation, a service layer, and Entity Framework Core for data access.
 
---
 
## ✨ Features
 
- 🎞️ **Full CRUD** — create, view, edit, and delete movies
- 📋 **Movie Listing Page** — table view of all movies with quick actions
- ✅ **Data Validation** — required title, max-length constraints, required release date (via Data Annotations)
- 🎭 **Genre Enum** — movies are categorized as `Drama`, `Comedy`, or `SciFi`
- 🧩 **Service Layer** — CRUD logic lives behind an `IMovieServices` interface, injected into the controller
- 🗃️ **EF Core + SQL Server** — movies are persisted via `MovieDbContext` with code-first migrations
- 💅 **Bootstrap UI** — responsive, styled views with client-side validation scripts included
---
 
## 🧱 Tech Stack
 
| Layer            | Technology                                |
|--------------------|----------------------------------------------|
| Framework            | ASP.NET Core 8 MVC                             |
| ORM                  | Entity Framework Core 8 (Code-First + Migrations) |
| Database              | SQL Server (LocalDB by default)                  |
| Views                 | Razor Views (`.cshtml`)                            |
| Styling                | Bootstrap 5, jQuery, jQuery Validation              |
 
---
 
## 📁 Project Structure
 
```
MovieProject/
├── Controllers/
│   ├── HomeController.cs        # Landing page, privacy, error handling
│   └── MovieController.cs       # CRUD actions for movies
├── Data/
│   └── MovieDbContext.cs        # EF Core DbContext
├── Migrations/                  # EF Core database migrations
├── Models/
│   ├── Entities/
│   │   └── Movie.cs             # Movie entity + Genre enum
│   └── ErrorViewModel.cs
├── Services/
│   ├── IMovieServices.cs        # Service contract
│   └── MovieServices.cs         # CRUD implementation
├── Views/
│   ├── Home/                    # Index, Privacy
│   ├── Movie/                   # Index, Create, Edit, Delete
│   └── Shared/                  # Layout, error page, validation partial
├── wwwroot/                     # Static assets (CSS, JS, Bootstrap, jQuery)
├── Program.cs                   # App startup & DI configuration
├── appsettings.json             # Configuration (connection string)
└── Imdb_418.csproj
```
 
---
 
## 🗃️ Data Model
 
**Movie**
 
| Field          | Type       | Notes                          |
|------------------|--------------|-----------------------------------|
| `Id`               | `int`          | Primary key                        |
| `Title`            | `string`       | Required, max 50 characters         |
| `Description`      | `string?`      | Optional, max 100 characters        |
| `ReleaseDate`       | `DateOnly`     | Required                            |
| `Genre`             | `Genre` (enum)  | `Drama`, `Comedy`, or `SciFi`        |
 
---
 
## 🚀 Getting Started
 
### Prerequisites
 
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (LocalDB works out of the box on Windows) or any accessible SQL Server instance
### 1. Clone the repository
 
```bash
git clone https://github.com/<your-username>/MovieProject.git
cd MovieProject
```
 
### 2. Configure the database connection
 
The default connection string in `appsettings.json` points to LocalDB:
 
```json
"ConnectionStrings": {
  "MovieDatabase": "Server=(localdb)\\mssqllocaldb;Database=imdb;Trusted_Connection=True;"
}
```
 
Update it if you're using a different SQL Server instance.
 
### 3. Apply database migrations
 
```bash
dotnet ef database update
```
 
This creates the `imdb` database using the migrations in `Migrations/`.
 
### 4. Run the app
 
```bash
dotnet run
```
 
Then open your browser to the URL shown in the console (typically `https://localhost:XXXX`) and navigate to **Movie** to start adding movies.
 
---
 
## 🗺️ Routes
 
| Route                | Description                  |
|-------------------------|---------------------------------|
| `/`                     | Home page                        |
| `/Movie`                | List all movies                  |
| `/Movie/Create`         | Add a new movie                  |
| `/Movie/Edit/{id}`      | Edit an existing movie           |
| `/Movie/Delete/{id}`    | Confirm & delete a movie         |
 
---
 
## 🛠️ Possible Improvements
 
Since this was built for practice, here are natural next steps:
 
- Add search/filtering and sorting on the movie list
- Add pagination for larger catalogs
- Add movie posters/images
- Add ratings and reviews
- Convert to a REST API + separate frontend (following the same pattern as other projects in this profile)
---
 
## 🤝 Contributing
 
This is primarily a learning project, but contributions, suggestions, and feedback are always welcome!
 
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request
---
 
## 📄 License
 
This project is available under the MIT License. Feel free to use it for learning or as a starting point for your own projects.
 
---
 
<p align="center">Made with ❤️ using ASP.NET Core MVC</p>
