
# Pierre's Sweet and Savory Treats

#### By: John Diggins

## Technologies Used

* C#
* HTML with Razor syntax
* Asp.NET 7
* MySQL
* Entity Framework Core 
* CSS

## Description
This is a website where a sweets shop has a menu of treats and flavors.  You can add your own treats and flavors to some of Pierre's classics.  Then you can create your own combinations of the classic french treats or add your own!


### Setup Instructions
1. Clone this repository.
2. Navigate to the local directory (PierresSweetAndSavory.Solution/PSAS) and create a new file `appsettings.json`.
3. Add the following to appsettings.json:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
4. Replace your username, password, and name of your database for [YOUR-USER-HERE], [YOUR-PASSWORD-HERE], and [YOUR-DB-NAME].
5. Go to your MySQLWorkbench and make sure your server is up and running with the same port, password, and user ID as indicated in the appsettings.json file.
5. **Look in `Factory.csproj` and make sure to remove comment for your correct dotnet version and comment out or delete the incorrect version.**
6. Create migrations with `dotnet ef migrations add Initial`
7. Update the database with `dotnet ef database update`.
8. In the command line, run the command `dotnet watch run` to compile and execute web application.  Then navigate to `localhost:5001` in your browser.
9. Create your own login or use default: admin, password: password.  There are pre seeded treats and flavors as well (Pierre's classics)


## Known Bugs
There is some extra code for future expandability.  I wanted to have an extra page that displayed all of the creations of your logged in user.  There also could be better security and the authorization could be better. I spent some time exploring extra features like seeding data and seeding an admin.

#### License
##### [MIT](https://github.com/git/git-scm.com/blob/main/MIT-LICENSE.txt)
##### Copyright (c) 2023 John Diggins