# TestAPI
Products api

Applicarions:
Visual studio code
SQL/SS management studio
Swagger
Postman

Instructions to create data and run tests:

1)  Open Visual Studio Code and load the 'Testapi' Folder containing .net code into visual studio code.
2)  Change 'appsettings.json' file to point to the database you are using.
3)  From a terminal window pointed to the 'Testapi' Folder run 'dotnet ef database update' to completion to create the 'TestAPI' SQL database, SSMS can be used to check and query the table and data.
4)  From a terminal window pointed to the 'Testapi' Folder run 'dotnet watch run'
5)  open swagger using http://localhost/5000/swagger
6)  Open Postman and import 'DatabaseDataSetup.postman' and 'tests.postman' files located within the 'Testapi' .net folder
7)  Within Postman run 'DatabaseDataSetup.postman' as a collection to load products 1 to 3.  If you already have products 1 to 3 in your database proceed to point 8.
8)  Within Postman run 'tests.postman' as a collection to run the test scripts.
