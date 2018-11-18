# SjeApi-App
.Net Core API to retrive data from MongoDB

This is a primitive boiler plate for a .NET Core Web API with Docker that interacts with MongoDB and performs CRUD operations.

This API obtains data from the MongoDB database hosted by DBaaS providers like mLab, Azure, AWS,etc. This can be done by using the database settings in appsettings.json. For different databases, different connection detail sets.

Things to do: 
1. Have a valid DB settings like connection host URL, credentials from DBaaS Provider 
2. Rename file appsettings_sample.json to appsettings.json
3. Replace the dummy values with actual values

Future Enhancements:
1. User authentication and authorisation module addition
2. Docker support for different runtimes
3. CORS support wherever required
4. Global Exception Handling
5. Add DI for Data Access Classes

