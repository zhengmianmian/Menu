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