# Dojo repository

This repository is for dojo hosting purposes.
Gitignore file is solely for dotnet core and C#.

Every dojo has to have its own branch.

## ArabicToRoman dojo

To setup similar starting point:

``` bash
dotnet new sln
dotnet new console ArabicToRoman
dotnet sln add ArabicToRoman
dotnet new nunit ArabicToRoman.Tests
dotnet sln add ArabicToRoman.Tests
dotnet add ArabicToRoman.Tests reference ArabicToRoman
dotnet add ArabicToRoman.Tests package Moq
```