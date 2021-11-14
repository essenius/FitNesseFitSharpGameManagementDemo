# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures. It include FitNesse test pages as well as 
corresponding C# fixtures, and gives examples of all the different FitNesse table types and associated fixtures.

# Installation
The steps to install are very similar to that of installing the [FibonacciDemo](../../../FitNesseFitSharpFibonacciDemo).

Differences are:
* If you want to use the end product rather than following the tutorial, then download the code as a zip file and extract the contents of the folder `FitNesseFitSharpGameManagementDemo-master` into %LOCALAPPDATA%\FitNesse. If you want to build up the tests and fixtures yourself, you can create your own C# .Net 5 libarary solution instead in the `GameManagement` folder (see below).
* Build command becomes: `dotnet build -configuration release %LOCALAPPDATA%\FitNesse\GameManagement\GameManagement.sln`
* Go to folder: `cd /D %LOCALAPPDATA%\FitNesse\GameManagement\GameManagementFixtures\bin\release\net5.0`
* Start FitNesse
* Run the suite: Open a browser and enter the URL http://localhost:8080/GameManagementSuite?suite

# Setting up your own fixture solution (instead of downloading it)
```
cd /d %LOCALAPPDATA\FitNesse
mkdir GameManagement
cd GameManagement
dotnet new sln
dotnet new classlib --framework "net5.0" -o GameManagement
dotnet sln add GameManagement
```

# Tutorial
See the [Wiki](../../wiki)

# Contribute
Enter an issue or provide a pull request. 
