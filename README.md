**CanadianResidencyStatus API Documentation**


*Overview*

The CanadianResidencyStatus API is a dynamic API developed using .NET Core and Entity Framework. It provides a seeded array of Canadian resident information and supports the four major HTTP methods (GET, POST, PUT, DELETE). The API returns data in JSON format, which can be easily integrated into your application or other formats as needed.

The API leverages the MVC (Model-View-Controller) architecture of .NET Core, though it excludes the View component since it is an API. The API includes Swagger for UI display, though POSTman can  be used to test the API instead.
 

*Introduction*
This documentation provides a detailed overview of the API endpoints available in the CanadianResidencyStatus application, including models and controllers, deployed to Microsoft Azure. The API facilitates operations on countries, jobs, residents, and status in Canada.

*Base URL*

The base URL for accessing the API is  https://canadianresidencystatusapi-hammed.azurewebsites.net/swagger/v1/swagger.json
Base URL

The base URL for accessing the API is  https://canadianresidencystatusapi-hammed.azurewebsites.net/swagger/v1/swagger.json

*Getting Started*
To interact with the API, use tools such as Swagger (which is conveniently accessible via the URL: https://canadianresidencystatusapi-hammed.azurewebsites.net/Swagger), Postman, or any HTTP client library like HttpClient in .NET, axios in JavaScript, or requests in Python. 

*Common HTTP Status Codes*
200 OK: The request was successful.
201 Created: A resource was successfully created.
204 No Content: The request was successful, but there is no content to send in the response.
400 Bad Request: The request was invalid.
404 Not Found: The requested resource was not found.



*API Endpoints*

#### Countries

##### GET: API/Countries

+ Description: Retrieves a list of all countries.
+ Response: 200 OK with a list of GetCountryDto.

+ Example: 

+ GET with swagger UI : canadianresidencystatusapi-hammed.azurewebsites.net
+ Raw date : canadianresidencystatusapi-hammed.azurewebsites.net/api/Countries


##### GET: /api/Countries/{id}

+ Description: Retrieves details of a specific country by ID where id can be any number between 1 - 5 based on the seeded data, Put endpoint can be utilized to add additional data..
+ Response: 200 OK with CountryDto or 404 Not Found.

+ Example:
+ GET : https://canadianresidencystatusapi-hammed.azurewebsites.net/api/Countries/1

##### POST: /api/Countries

+ Description: Creates a new country.
+ Request Body: CreateCountryDto
+ Response: 201 Created with the created Country.

+ Example: Use the link to the swagger UI.

##### DELETE: /api/Countries/{id}
+ Description: Deletes a specific country by ID.
+ Response: 204 No Content or 404 Not Found.
+ Example: Check the video attached to this documentation.
+ In addition, a brief illustration of how to integrate all the endpoints of the API can be found in the attached video.


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

Other operations can also be performed on the API. The status code of 200 indicates that everything is working correctly.
