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


7 aug:

Now we have two application for CICD:
1.src/productservice
2.test/MyTest
add reference of productservice in mytest->csproj
Note:Adapter is a runner of testcase

=>1.Now we have created the pipeline and to run the pipline we have the agent which running
locally as a window services

2. dotnetcore..github....devops....

11aug: 

Multistaging yml file:(one series everything)

steps for pipeline to create continous Integration(Trigger) , continous Deployment
1.Trigger:
2: Agent:
3: dotnet sdk Version
4: dotnet restore(csproj)
5:csproj with build
6: publish(csproj location)
7,8,9,10 steps(additonal task)
11. deployment
  a. Service Connection name of azure
  b.Azure app service name


Note: csproj is more imp for pipline

-----------------------------------------------------------------------------------
22 aug:

Architecture of Azure APIM:

https://devopsapiservicecicd001-hyf3cqd2cpajfrfe.centralindia-01.azurewebsites.net/swagger/v1/swagger.json

Actual session of Microservices

1.productservice
2.discountservice

About APIM:

1.APIM provides a feature known as  API'.
 2. Within Apis we have multiple templates like OpenAPI(Rest api's), WSDL etc.
 3. APIM(Gateway)[UppStream] and Api's[Downstraem](service like product service,orderservice...).

 4. Open API Specification:

    Display name:productservice
    
    Name : productservice ---->Downstream
    
    API URL suffix :  muskanproductservice ---> UppStream
   
    Base URL : https://muskan-apim.azure-api.net/muskanproductservice