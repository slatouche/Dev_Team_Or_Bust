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
    - ☑ Setup dependency injection to be able to swap repo used in controller
        - Add scoped mapping to Startup.ConfigureServices
        - Add contructor to controller to be able to inject dependency
    - ☑ Setup DBContext data access to get EF connection to DB
        - DBContext = TestDBContext
        - Connection String = DBConnection (in appsettings.json)
        - ConfigureServices services.AddDbContext with opt.UseSqlServer
    - ☑ Run EF Migrations to setup TestModel DB in SqlServer
    - ☑ Manually add some placeholder data to SqlServer TestModel DB
    - ☑ Swap mock repo for implementation using DBContext
    - ☑ Able to load data from Sql Server DB using postman
    - ☐ More TBA