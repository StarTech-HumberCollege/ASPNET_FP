# ASPNET_FP

1. Please install packages with correct versions in Package Manager Console:
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.5
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.5
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 6.0

2. Please make sure the database name of ConnectionStrings/appsettings.json is case-sensitive.

3. Update database before running the project:
Update-Database
