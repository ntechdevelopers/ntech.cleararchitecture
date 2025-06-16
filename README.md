# Introduction 
This project is a .NET Clean Architecture solution designed to provide a scalable and maintainable structure for building robust applications. It separates concerns into distinct layers—Domain, Application, Infrastructure, and Web API—to ensure a clear and organized codebase. The primary objective is to facilitate easy testing, maintenance, and scalability while adhering to best practices in software development.

# Project Structure
This project follows the Clean Architecture pattern, organized as follows:

- **CleanArchitecture/**
  - `docker-compose.yml`, `docker-compose.override.yml`: Docker configuration files for running the solution.
  - **Ntech/**
    - `Ntech.sln`: Solution file.
    - **Ntech/**
      - **Ntech.Infrastructure.Shared/**: Shared infrastructure services and registrations.
      - **Ntech.Infrastructure.Persistence/**: Data persistence, repositories, and migrations.
      - **Ntech.Infrastructure.Identity/**: Identity, authentication, and related services.
      - **Ntech.Domain/**: Domain entities, value objects, and core business logic.
      - **Ntech.Application/**: Application logic, DTOs, interfaces, and features.
      - **Ntech.WebApi/**: ASP.NET Core Web API entry point, controllers, and configuration.

# Getting Started
To run the project using Docker Compose:

```sh
cd CleanArchitecture
# Build and start all services
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --build
```

TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)

--
Ntech