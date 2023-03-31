# Animal House API
### By Mitchell Gantz

### An Api for managing dogs and cats for a fictional shelter  

🐱 [Documentation](#api-documentation)

🐶 [Project Details](#project-details)

🐱 [Setup/Installation Guide](#setup/installation-guide)

🐶 [Bugs](#known-bugs)

🐱 [License](#license)


# Technologies Used

   * C#
   * ASP.Net 6
   * EFCore
   * MySQL
   * LINQ
   * SwaggerUI
   * bootstrap
   * Postman

# Project Details
* Implement an API with full CRUD functionality
* Implement one(or more) of the following: authentication, versioning, pagination, or CORS
* full API documentation required.

# Further Explporation Objective
* We are looking for your best effort in implementing a further exploration objective. Why? Some are more challenging than others, like authentication. We want to encourage you to challenge yourself for this project and not feel the pressure of needing to successfully complete an objective to simply pass. With the time you had in class to work on further exploration and the skills you have at the end of this course, we generally expect to see that most students complete this objective.

* Your teacher will review your README and your commit history to understand your progress on implementing a further exploration objective. If you do not complete a further exploration objective, make sure that your project documentation reflects this. We recommend updating the "Known Bugs" section of your README, but you may find a better location to relay this information.

# #Setup/Installation Guide
 
## Set up the API
* Clone the repository 
* Navigate to the `AnimalHouseApi` folder
* Open a command line and enter the following:
  ```
  dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
  dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
  dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
  dotnet ef database update
  ```
* add a file in the PetShelterApi directory called `appsettings.json` and add the following code, replacing the password/user field with your credentials:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=AnimalHouseApi;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
  }
}
```

# Running the program
* Start the API by opening a command line in the `AnimalHouseApi` directory and enter `dotnet run`


### API Documentation

## Endpoints
```
GET http://localhost:5000/api/v1animals/
GET http://localhost:5000/api/v1animals/{id}
POST http://localhost:5000/api/v1animals/
PUT http://localhost:5000/api/v1animals/{id}
DELETE http://localhost:5000/api/v1animals/{id}
```
    
## Query Examples
  
  * You may query specific entry IDs by appending it to the end:
      ```
      GET https://localhost:5001/api/v1Animals/4
      ```

  * A body is required for POST requests. Example of a good request would be:
      ```
      { 
        "name": "ChopSticks",
        "species": "Cat",
        "subSpecies": "Siamese",
        "age": 3,
      }
      ```
  * An ID is required for PUT requests (modifying an existing entry) including the ID of the entry:
      ```
      {
        "animalId": 1,
        "name": "FuzzyWasHe",
        "species": "Cat",
        "subSpecies": "Persian",
        "age": 10,
      }
      ```
  * To delete an entry, simply enter the id of the entry you'd like to delete:
      ```
      DELETE  https://localhost:5001/api/v1Animals/8
      ```

# Known Bugs

- _If you find additional bugs not listed here, please email me at mgantz22@icloud.com with the subject_ **[_Repo Name_] Bug** _and include:_
  - BUG: _A brief description of the bug_
  - FIX: _Suggestion for solution (if you have one!)_
- _If you'd like to be credited, please also include your_ **_github user profile link_**


## License

MIT License

Copyright (c) 2023 Mitchell Gantz 

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.