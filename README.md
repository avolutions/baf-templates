# Avolutions BAF Templates

Project templates for creating new applications with Avolutions Business Application Framework (BAF).

## Install

```bash
dotnet new install Avolutions.Baf.Templates
```

## Templates

### Blazor

Create new Blazor app:
```bash
dotnet new baf-blazor -n MyApp
```

Apply BAF migrations:
```bash
dotnet ef migrations add AddBafTables
```

```bash
dotnet ef database update
```

Start the app.
