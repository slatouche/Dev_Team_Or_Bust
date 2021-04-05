# Dev_Team_Or_Bust

--- AIM
- To make a simple React app using Entity Framework and Web API
- Follow CQRS pattern

--- Tasks
- ☑ Get an Entity Framework test project working using Web API
    - /WebApi_EF_Test/README.md for more info


    
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
        - ☑ Create Domain Entity
            - Activity
        - ☑ Add EF DbContext 
            - DataContext in Persistence
            - Activity DbSet
            - Sqlite Connection in Startup
            - Connection String in appsettings
        - ☑ EF Initial Migration + DB Setup
            - Make Program.cs try run migration before host Run
        - ☑ Seed data for Sqlite DB
            - Create seed data (./Persistence/Seed.cs)
            - Load Seed Data, Migration + Run async
        - ☑ Add Controllers
            - Base API Controller
            - Activities Controller + Routes
                - Get Activities
                - Get Activity By Guid
    - ☐ Client Skeleton
        - TBA
    - ☐ Add CQRS
        - TBA