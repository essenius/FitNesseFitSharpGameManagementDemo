# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures. It include FitNesse test pages as well as 
corresponding C# fixtures, and gives examples of all the different FitNesse table types and associated fixtures.

# Installation
The steps to install are very similar to that of installing the [FibonacciDemo](https://github.com/essenius/FitNesseFitSharpFibonacciDemo).

Differences are:
* Extract the contents of the folder ```FitNesseFitSharpGameManagementDemo``` (instead of FitNesseFitSharpFibonacciDemo)
* Build command becomes: ```dotnet build %LOCALAPPDATA%\FitNesse\GameManagement\GameManagement.sln```
* Go to folder: ```cd /D %LOCALAPPDATA%\FitNesse\GameManagement\GameManagementFixtures\bin\debug\net5.0```
* Run the suite: Open a browser and enter the URL http://localhost:8080/GameManagementSuite?suite

# Tutorial
See the [Wiki](../../wiki)
# Contribute
Enter an issue or provide a pull request. 
