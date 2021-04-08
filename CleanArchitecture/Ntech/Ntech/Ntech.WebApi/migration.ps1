#dotnet ef migrations add InitDatabase

dotnet ef database update --context IdentityContext
dotnet ef database update --context ApplicationDbContext