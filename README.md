<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/BlindGarret/recipe-api">
    <img src="images/logo.png" alt="Logo" width="150">
  </a>

  <h3 align="center">RecipeBook</h3>

  <p align="center">
    A simple recipe API for the Home Recipe Cookbook project.
    <br />
    <a href="https://github.com/BlindGarret/recipe-api/issues">Report Bug</a> |
    <a href="https://github.com/BlindGarret/recipe-api/issues">Request Feature</a>
  </p>
</p>

### Built With

* [NetCore 5](https://netcore.microsoft.com/)
* [Docker](https://www.docker.com/)
* [AutoMapper](https://automapper.org/)
* [JWT](https://github.com/jwt-dotnet/jwt)
* [MySQL](https://mysql.com/)
* [NHibernate](https://nhibernate.info/)
* [NSwag](https://github.com/RicoSuter/NSwag)
* [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

Visual Studio 2019+

### Installation

The application is designed to simply be debugged via the VS2019 debug functionality. The only requirement is that you have a
MySql Instance to hook up to via the connection string inside RecipeBook.Api/appsettings.Development.json. There is a provided docker-compose.yml
which will allow you to standup a local instance of MySQL with dev settings using the command:

```ps1
    docker compose up -d
```


<!-- CONTACT -->
## Contact

Project Link: [https://github.com/BlindGarret/recipe-api](https://github.com/BlindGarret/recipe-api)