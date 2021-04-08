# Dev_Team_Or_Bust

--- AIM
- To make a simple React app using Entity Framework and Web API
- Follow CQRS pattern

--- Tasks
- ☑ Get an Entity Framework test project working using Web API
    - /WebApi_EF_Test/README.md for more info

<br>

- ☐ Demo Project With Both EF WebAPI and React
    - ☑ API Skeleton
        - ☑ Dotnet sln
            - API (webapi)
            - Application (classlib)
            - Domain (classlib)
            - Persistence (classlib)
        - ☑ Add proj dependency references
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
            - Code First migration
            - Make Program.cs try run migration before host Run
        - ☑ Seed data for Sqlite DB
            - Create seed data (./Persistence/Seed.cs)
            - Load Seed Data, Migration + Run async
        - ☑ Add Controllers
            - Base API Controller
            - Activities Controller + Routes
                - Get Activities        -> {{url}}/api/activities/
                - Get Activity By Guid  -> {{url}}/api/activities/{id}
    - ☑ Client Skeleton
        - ☑ Create react app
            - npx create-react-app client-app --use-npm --template typescript
        - ☑ React project setup and install
            - React Dev tools
            - Typescript
            - Axios + CORS
            - Semantic-ui
        - ☑ App able to GET data from API
        - ☑ List activities from API with basic styling
    - ☐ Add CRUD to App while using CQRS Pattern
        - Install MediatR
        - Create Query handler for GET Activites list
        - Create Query handler for GET Activity details
        - TBA