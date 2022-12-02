# Introduction 
This is an project that can be used to practice TDD. 
It is based on the game of Master Mind (also known with many other names)
[See Wikipedia for game rules](https://en.wikipedia.org/wiki/Mastermind_(board_game))

As of now it is available in C# and JavaScript (NodeJs).

The goal of the game is to guess an 4-digit secret code. For each guess the system provides feedback on how many of the guess are actually in the code and how many are at the right position. Using TDD developers should now implement the logic calculating the correct feedback result.

# Getting Started

## C#
The C# version is based on .NET6. 

The easiest way to run this version might be in using Visual Studio or VSCode.

You can also use ```dotnet run --project MasterMind.App``` to run the application and 
```dotnet test``` to run  tests.

## JavaScript / NodeJs
The code has been created by using [VSCode](code.visualstudio.com) but any other IDE should also be sufficient.

The NodeJs version can be run by typing ```node index.js```
To execute tests either use the Test Explorer inside VSCode or type ```npm test```


# Contribute
If you would like to contribute improvements or new language versions, just create a PR.
