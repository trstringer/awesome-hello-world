# ASP.NET Web API Hello World

## Pre-Code Install/Configuration
1. If you don't already have Visual Studio in your machine, [download Visual Studio Community](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx) for free

## Development Steps

1. Start Visual Studio
2. Create a new ASP.NET Web Application project by doing the following...
  1. *File* -> *New* -> *Project...*
  2. Under *Templates* select *Visual C#* -> *Web* -> ***ASP.NET Web Application***
  3. Click *OK*
  4. In the *Template* dialog select ***Web API***
3. Right-click on the *Controllers* folder and select *New Controller*
4. Create an *empty controller*
5. Name the controller `HelloWorldController` when prompted
6. Understand and write the code found in `HelloWorldController.cs` into your `*.cs` controller file in the project
7. Run/debug the web application
8. In the system tray, right-click *IIS Express* and note which port your web application is listening on
9. Make an HTTPGET request by typing the following in your web browser `http://localhost:33006/api/helloworld` (substitute `33006` with your web app's listening port from IIS Express)
10. Conversely, you can test this out by making a web request in PowerShell by typing the following into a PowerShell console host: `Invoke-WebRequest "http://localhost:33006/api/helloworld" | Select-Object Content` (again, substitute the correct port number)