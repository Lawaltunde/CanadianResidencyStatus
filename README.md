**CanadianResidencyStatus API Documentation**


*Overview*

The CanadianResidencyStatus API is a dynamic API developed using .NET Core and Entity Framework. It provides a seeded array of Canadian resident information and supports the four major HTTP methods (GET, POST, PUT, DELETE). The API returns data in JSON format, which can be easily integrated into your application or other formats as needed.

The API leverages the MVC (Model-View-Controller) architecture of .NET Core, though it excludes the View component since it is an API. The API includes Swagger for UI display, though POSTman can  be used to test the API instead.
 

Setting Up the API:

The API includes third-party application called Cross-Origin Resource Sharing (CORS), allowing the API to be accessible by clients on different servers. Image below is a code snippet extracted from program.cs demonstrating the integration of CORS into the application.

<img width="563" alt="CORS" src="https://github.com/Lawaltunde/CanadianResidencyStatus/assets/122512872/7dd7270d-cd52-4fff-bfc1-460a8bdc7565">
To enable CORS in the application, you must activate the relevant policy in your program.

**Model-View-Controller (MVC) Architecture**

+ Model: Contains the business logic and database models.
+ View: Not applicable to this API.
+ Controller: Manages requests and responses between the Model and the client. It processes incoming requests, interacts with the Model, and sends the appropriate response back to the client.

In this API, the absence of a View means we focus on the Model and Controller (MC). The Model is represented as Data in this project. Swagger and Postman are used during development in place of a traditional View.

**Entity Framework**

Entity Framework enables database integration, allowing the API to be dynamic. The seeded data can be updated, retrieved, and deleted using this framework supported by .NET Core.

**THE API Functionality**

Below is an example of how the API's UI displays on Swagger:

<img width="611" alt="View" src="https://github.com/Lawaltunde/CanadianResidencyStatus/assets/122512872/1817bd7d-48f5-4ac9-83db-69b8cdd70c0d">
<img width="582" alt="view 2" src="https://github.com/Lawaltunde/CanadianResidencyStatus/assets/122512872/ab27e66b-469d-49a7-99e2-fba40a296bfb">

Example Operation: Retrieving Resident Details
To retrieve the details of a resident with "Id = 1":

<img width="295" alt="view 3" src="https://github.com/Lawaltunde/CanadianResidencyStatus/assets/122512872/27b48527-fe0a-40bd-a7f9-c62d2179dfaa">

Other operations can also be performed on the API. The status code of zero indicates that everything is working correctly.
