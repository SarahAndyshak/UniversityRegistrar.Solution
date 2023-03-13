# _University Registrar_

#### By _Erin Timlin, Jake Maier, & David Jandron_

#### _A C# web application using MySQL that creates a website for a university registrar_

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MYSQL_

## Description

_This is site built for users to enter new students...._

## Setup/Installation Requirements

* Clone this repo.
* Open the terminal and navigate to this project's production directory called "UniversityRegistrar.Solution".
* Within the production directory "UniversityRegistrar", create a new file called appsettings.json.
* Within appsettings.json, put in the following code.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=university_registrar;uid=root;pwd=epicodus;"
  }
}
* Within the production directory "University Registrar", run dotnet watch run in the command line to start the project in development mode with a watcher.

* Open the browser to https://localhost:5001.


## Known Bugs

* _N/A_

## License

_MIT License_

Copyright (c) _2023_ _authored by: Erin Timlin, Jake Maier, & David Jandron_