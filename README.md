# MVC-dotNetCore-EntityFramework

Entity framework: asp.net core=>

create folder Data:
data:
	create class Name_DBcontext and inherit from a class DBContext
      create a constructor for it and use dbOtions and base

	create a class that matches the creation of the table
	add that class in the Name_dbcontext class using DBSet

inside startup.cs configurationservice
		services.addDBContext<Name_dbContext>(dbcontext =>dbcontext.UseSqlserver(Configuration.ConnectionString("connectionstring_name_spefied_in_appsettings.json")"

inside the appsettings.json

"connectionstring":{
"connectionstring_name_spefied_in_appsettings.json" :"server=serverName; database=database_name;integrated security=true;userid=userName;password=password_is;"
}


For code first approach:
inside the NuGet package command:
add-migration init 
update-database

for Data First approch:
inside the nuget package command:
Scaffold-DbContext "Server=server_name;Database=DBname;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


libraries required:
microsoft.entity.frameworkcore
microsoft.entity.frameworkcore.sqlserver
microsoft.entity.frameworkcore.tools
microsoft.entity.frameworkcore.design
microsoft.entity.frameworkcore.relational
