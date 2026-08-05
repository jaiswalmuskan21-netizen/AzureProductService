az login --use-device-code -> login



Concepts of Fatty Controller:


Sql Authentication:
Server=tcp:productdbbs-server.database.windows.net,1433;Initial Catalog=productdbs;Persist Security Info=False;User ID=sqlserverdbsdmin;Password= admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;


KeyVault Configuration:

_______________________________________________________

KeyVault Url: https://muskankeyvaultkey.vault.azure.net/

Connectionstring: Server=tcp:productdbbs-server.database.windows.net,1433;Initial Catalog=productdbs;Persist Security Info=False;User ID=sqlserverdbsdmin;Password=admin@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;


---------------------------------------------------------------------------------------------------
Pre-requisite for CICD:

____________________________________________________________________________
30 july:

Dotnetcore  keyVault ->Manage identy--> sqlserver(old way{App Registration})
steps for accessing the key vault :
1.Key vault Url: https://muskankeyvaultkey.vault.azure.net/

2. What kind of configuration is required for key vault in program.cs?
Identity: <PackageReference Include="Azure.Identity" Version="1.21.0" />
            <PackageReference Include="Azure.Extensions.AspNetCore.Configuration.Secrets" Version="1.5.1" />


__________________________________________________________________________________

31 july:

KeyVault = Config+ Encryption + hashing + Logging + Access Control + Rotation

4th aug:


1. Devops: 
2.GitHub
3.Agent
4. Pool on GitHub
5. devops classic Architecture
6. Azure App service


steps:


…or create a new repository on the command line:

echo "# AzureProductService" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/jaiswalmuskan21-netizen/AzureProductService.git
git push -u origin main

…or push an existing repository from the command line:

git remote add origin https://github.com/jaiswalmuskan21-netizen/AzureProductService.git
git branch -M main
git push -u origin main