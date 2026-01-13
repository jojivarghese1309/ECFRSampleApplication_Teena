# ECFRSampleApplication_Teena
This is created by Teena to access the sample application

## Electronic Case Filing Records (ECFR) Sample Application

This is a sample ASP.NET Core MVC application demonstrating an Electronic Case Filing Records (ECFR) system.

### Features
- Case file management
- Electronic filing records
- Sample data for demonstration

### Technology Stack
- .NET 10.0
- ASP.NET Core MVC
- C#

### Project Structure
```
ECFRApp/
├── Controllers/         # MVC Controllers including CaseFileController
├── Models/             # Data models including CaseFile
├── Views/              # Razor views for UI
│   ├── Home/          # Home page views
│   ├── CaseFile/      # Case file management views
│   └── Shared/        # Shared layout and components
├── wwwroot/           # Static files (CSS, JavaScript, images)
├── Program.cs         # Application entry point
└── appsettings.json   # Configuration settings
```

### Building the Application

1. **Prerequisites:**
   - .NET 10.0 SDK or later

2. **Build the solution:**
   ```bash
   dotnet build ECFRApp.sln
   ```

3. **Run the application:**
   ```bash
   cd ECFRApp
   dotnet run
   ```

4. **Access the application:**
   - Open a browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Getting Started

After running the application, you can:
1. View the home page with welcome message
2. Navigate to "Case Files" to see sample electronic case filing records
3. View details of individual case files

### Notes
This is a sample application for demonstration purposes. It uses in-memory data and does not persist information to a database.

