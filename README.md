# Implement shapes

## Description
It is a web application, that uses ASP.NET Core MVC framework with controllers and views. The site is fetching data asynchronously from backend which is using HackerNews API.[Geometry].

## Tasks

### Implement shapes

- Implement the constructors and the required methods in shape subclasses. The shapes must be immutable. that is, their state (stored in attributes) cannot be changed.
- All attributes are immutable.
- All attributes are private, and only the methods and properties used by other classes are not private.
- All shape subclasses have an overridden version for calculating the corresponding perimeter and area.
- All shape subclasses have (or inherit) their custom ToString() representation. The representation includes the name of the shape (such as "Rectangle") and the names and values of its base attributes (in this case "r=...").



### Shape collection

- Implement ShapeCollection to manage a list of shapes. The collection can consist of any subtype of Shape.
- It is possible to add shapes to the collection using the AddShape method.
- The GetShapesTable() method returns a printable table with all the shapes in the collection and their parameter values. The table looks like the example in table_example.txt.
- The GetLargestShapeByPerimeter() method returns the shape instance with the largest perimeter in the collection.
- The GetLargestShapeByArea() method returns the shape instance with the largest area in the collection.



### Main menu

- Implementing a list to help manage the shapes -> ,,ShapeCollection”
- It is possible to add new shapes, by choosing one from a list and adding its parameter(s) -> ,,Add new shape”
- It is possible to list all of the existing shapes -> ,,Show all shapes”
- The user is able to search for the shape with the largest perimeter and largest area -> ,,Show shape with the largest perimeter” and ,,Show shape with the largest area”
- The user can select from a list of existing shapes and show it’s stored formulas (area, perimeter) -> ,,Show formulas”
- Implementing an option to make it easier to exit the program -> ,,Exit”



## Requirements

- create a new **feature branch** and commit every change to your Github repo
- It’s even better if you make [atomic commits](https://en.wikipedia.org/wiki/Atomic_commit)



### Features

- Draw UML class diagrams.
- Use inheritance.
- Override methods.
- Understand when static contexts (the static keyword) can be useful.
- Understand hiding (the new keyword) vs overriding (the override keyword).
- Use sealed.
- Represent objects with strings.



# Background materials
##### [Static keyword](https://www.geeksforgeeks.org/static-keyword-in-c-sharp/)
##### [UML](https://plantuml.com/class-diagram)
##### [Abstract Class And Abstract Method In C#](https://www.c-sharpcorner.com/UploadFile/93126e/importance-and-use-of-versioning-in-C-Sharp/)
##### [new modifier](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier)

