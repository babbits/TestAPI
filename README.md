# TestAPI
Products api

Instructions to create data and run tests:

1)  Open Visual Studio Code and load the 'Testapi' Folder containing .net code into visual studio code.
2)  From a terminal window pointed to the 'Testapi' Folder run 'dotnet ef database update' to completion to create the 'TestAPI' SQL database, SSMS can be used to check and query the table and data.
3)  From a terminal window pointed to the 'Testapi' Folder run 'dotnet run'
4)  Open Postman and import 'backend test API updated.postman' file located within the 'Testapi' .net folder
5)  Within Postman run 'backend test API updated' as a collection, this will activate Postman Collection runner: if your environment already has products 1 to 3 set up then untick scripts located in the 'SetupProducts123' folder:  Postman Collection runner will show 'backend test API updated', the folder 'SetupProducts123' within the collection will set up inital products data, if your environment already has products 1 to 3 set up then untick scripts located in the 'SetupProducts123.
