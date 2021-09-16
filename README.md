# Introduction 
This repo contains a demo suite on how to use FitNesse with FitSharp and C# fixtures. It include FitNesse test pages as well as 
corresponding C# fixtures, and gives examples of all the different FitNesse table types and associated fixtures.

# Getting Started
1. Ensure you have Java installed (1.8 or higher)
1. Download FitNesse (http://fitnesse.org) and install it to ```C:\Apps\FitNesse```
1. Install FitSharp 2.8.2.1 or higher into ```C:\Apps\FitSharp```. The easiest way to do that is using the NuGet CLI which you can get from from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe:
```
nuget install fitsharp -OutputDirectory C:\Apps -ExcludeVersion
```
4. Clone the repo to a local folder (```C:\Data\FitNesseDemo```)
1. If you took a different folder for FitSharp, update ```plugins.properties``` to point to the right folder
1. Build the solution ```GameManagement```
1. Start FitNesse with the root repo folder as the data folder, and the assembly folder as the current directory:
```
cd /D C:\Data\FitNesseDemo\GameManagement\GameManagementFixtures\bin\debug\net5.0
java -jar C:\Apps\FitNesse\fitnesse-standalone.jar -d C:\Data\FitNesseDemo -e 0
```
9. Open a browser and enter the URL http://localhost:8080/GameManagementSuite?suite

# Contribute
Enter an issue or provide a pull request. 
