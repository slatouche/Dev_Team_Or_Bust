# Dev_Team_Or_Bust

--- AIM
- To make a simple React app using Entity Framework and Web API
- Follow CQRS pattern

--- Current Tasks
- Get an Entity Framework test project working using Web API
    - ☑ Setup using "webapi" dotnet template  (dotnet new webapi -n WebApi_EF_Test)
    - ☑ Setup basic SQL Server (using SQL Server Express)
    - ☑ Create test model
    - ☑ Create data/repository interface
    - ☑ Create mock repository implementation with mock data
    - ☑ Create test controller with API route getting data from mock repo
    - ☑ Run and test with postman
        --- Current API End Points
        - (GET) http://localhost:5000/api/TestModels         -> GetAllTestModels
        - (GET) http://localhost:5000/api/TestModels/{id}    -> GetTestModelByID
    - ☐ More TBA