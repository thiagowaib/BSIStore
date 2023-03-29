# BSISTORE

## Comandos

MVC Scaffolding:
dotnet aspnet-codegenerator controller 
-name FuncionarioController 
-m Funcionario 
-dc BSIStore
--relativeFolderPath Controllers 
--useDefaultLayout 
--referenceScriptLibraries 
-sqlite

Migration Add
dotnet ef migrations add <migration-name>

Migration Update
dotnet ef database update