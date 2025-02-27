# Menu
A simple menu that helps learn .Net MVC.

## Tech stack
- .Net 8.0
- Razor

## Learning points
- Add models
- Create controllers
- Show data in razor pages
- Connection to MS SQL Server


## Run the app
In the root:
```
dotnet run
```

## Notes
Do migration. Check the [docs](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli#update-the-database).

Run commands in the root folder:

Install the tool if hasn't:
```
dotnet tool install --global dotnet-ef
```
```
dotnet ef migrations add InitialCreate
```
```
dotnet ef database update
```