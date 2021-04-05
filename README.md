# Dev_Team_Or_Bust

--- AIM
- To make a simple React app using Entity Framework and Web API
- Follow CQRS pattern

--- Current Tasks
<details>
<summary>
- ☑ Get an Entity Framework test project working using Web API
</summary>
<br>
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
        - (POST) http://localhost:5000/api/TestModels        -> CreateTestModel
        - (PUT) http://localhost:5000/api/TestModels/{id}    -> UpdateTestModel
        - (DELETE) http://localhost:5000/api/TestModels/{id} -> DeleteTestModel
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
    - ☑ Setup DTO's with AutoMapper for CRUD operations to/from DB
        - Add AutoMapper Service to startup
        - DTO for CRUD (DTO also to not return TestInt)
        - Mapper Profile for DTO
        - Implement DTOs in controller
        - Add CRUD + SaveChanges to Interface
        - Add to Repo Implementation
    - ☑ Test EF WebAPI project with CRUD working
</details>

- ☐ Demo Project With Both EF WebAPI and React
    - ☐ API Skeleton
        - ☑ Dotnet sln
            - API (webapi)
            - Application (classlib)
            - Domain (classlib)
            - Persistence (classlib)
        - ☑ Add proj references
            - API
                - Application
            - Application
                - Domain
                - Persistence
            - Persistence
                - Domain
        - Create Domain Entity
            - Activity
        - Add EF DbContext 
            - DataContext in Persistence
            - Activity DbSet
            - Sqlite Connection in Startup
            - Connection String in appsettings
        - EF Initial Migration + DB Setup
            - Make Program.cs try run migration before host Run
        - Seed data for Sqlite DB
            - Create seed data (./Persistence/Seed.cs)
            - Load Seed Data, Migration + Run async
        - Add Controllers
            - Base API Controller
            - Activities Controller + Routes
                - Get Activities
                - Get Activity By Guid
    - ☐ Client Skeleton
        - TBA
    - ☐ Add CQRS
        - TBA