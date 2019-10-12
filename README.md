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
4)  From a terminal window pointed to the 'Testapi' Folder run 'dotnet run'
5) open swagger using https://localhost/5000/swagger/
6)  Open Postman and import 'backend test API updated.postman' file located within the 'Testapi' .net folder
7)  Within Postman run 'backend test API updated' as a collection, this will activate Postman Collection runner: if your environment already has products 1 to 3 set up then untick scripts located in the 'SetupProducts123' folder:  Postman Collection runner will show 'backend test API updated', the folder 'SetupProducts123' within the collection will set up inital products data, if your environment already has products 1 to 3 set up then untick scripts located in the 'SetupProducts123.
