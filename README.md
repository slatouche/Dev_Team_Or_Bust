# Dev_Team_Or_Bust

--- AIM
- To make a simple React app using Entity Framework and Web API
- Follow CQRS pattern

--- Current Tasks
- Get an Entity Framework test project working using Web API
    - ☑ Setup using "webapi" dotnet template  (dotnet new webapi -n WebApi_EF_Test)
    - ☑ Setup basic SQL Server (using SQL Server Express)
    - ☐ Create test model
    - ☐ Create data/repository interface
    - ☐ More TBA

--- Current API End Points
- (GET) /api/TestModels         -> GetAllTestModels
- (GET) /api/TestModels/{id}    -> GetTestModelByID