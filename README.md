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
## Screenshots
The menu page:
![Home](https://github.com/user-attachments/assets/8b008dcf-a554-42ce-94d3-ecebd87bf002)


The details page:

![Details](https://github.com/user-attachments/assets/4d43d8c0-d956-4759-b045-8d3d57ccf90f)

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
