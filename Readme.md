## Basic Resume Builder
This past days we learned about design patterns. One of the design patterns which we learned was factory.
Factory is very similar to interfaces in which there are implementation of items.



## Author:
Tiger Hsu

## Version:
2.0.0 

## Overview
Build a basic resume.
Product-> This product is a reusme
Concrete Product -> Experience, Work History, Profile, are indivudual items which them can become a much larger
in the page class; they are inherited to the 
Creator-> Document <List> is the Creator 
Concrete Creator -> Resume builder

## Factory Design
<li> Concrete Classes-> Documents;
<li> Factory -> This creates the new instances of Documents.  public List <Page> create a new <Page>
<li> Concrete -> Concreate classes are the Letter references and Work history.


## Getting Started
1. Clone the repository to your local machine.
2. Select into application directory where the *AppName.sln* exist.
3. Open the application using *Open/Start AppName.sln*.
5. The website will run on your default web browser routing to the main home page.

## Example

![alt text](Design-Pattern.bmp)



## Architecture
 - C# ASP.NET Core application.
 - MVC architectural design pattern.
 - Entity Framework - built in Visual Studio

## Resources
StackoverFlow
Microsoft Docs

## License
MIT License

