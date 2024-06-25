# Book Store CRUD

## Description
This project is an ASP.NET Core Web API application that utilizes Entity Framework Core for database interactions and Swagger for API documentation.

## Technologies Used
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)

 ## Installation

 1. Clone the repository:
    
        git clone https://github.com/mcoldibelli/bookstore.git

        cd bookstore

 2. Restore the project dependencies:
        
        dotnet restore

3. Start the Docker container:

        docker-compose up -d

4. Apply the database migrations:
       
       dotnet-ef database update

5. Run the application:

       dotnet run

The application should now be running on https://localhost:7106 (or http://localhost:5001).

## Security Notice

### Database Password in Plain Text

For simplicity and ease of setup, the database password is stored in plain text within the `docker-compose.yml` file. This approach is used because this project is not intended for deployment to a production environment.

