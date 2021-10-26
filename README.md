# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures. It include FitNesse test pages as well as 
corresponding C# fixtures, and gives examples of all the different FitNesse table types and associated fixtures.

# Installation
The steps to install are very similar to that of installing the [FibonacciDemo](../../../FitNesseFitSharpFibonacciDemo).

Differences are:
* If you want to use the end product rather than following the tutorial, then download the code as a zip file and extract the contents of the folder `FitNesseFitSharpGameManagementDemo`. If you want to build the tests and fixtures up yourself, you don't need to do this step.
* Build command becomes: `dotnet build %LOCALAPPDATA%\FitNesse\GameManagement\GameManagement.sln`
* Go to folder: `cd /D %LOCALAPPDATA%\FitNesse\GameManagement\GameManagementFixtures\bin\debug\net5.0`
* Run the suite: Open a browser and enter the URL http://localhost:8080/GameManagementSuite?suite

# Tutorial
See the [Wiki](../../wiki)

# Contribute
Enter an issue or provide a pull request. 
