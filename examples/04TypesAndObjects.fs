// aka a record
// Records are essentially sealed classes with extra topping: default immutability, structural equality, and pattern matching support.
// https://github.com/adelarsq/fsharp-cheatsheet#TypesAndLiterals

module fSharpExamples.TypesAndObjects
type Person = { name : string; age : int }
type Person with 
    static member Kevin = {
        name = "Kevin"
        age = 39
    }
let k = Person.Kevin


// classes are different
// https://fsharpforfunandprofit.com/posts/classes/
// created with a ctor, have () after the class name
// You could use "this" or "self" or "me" or any other word that commonly indicates a self reference.
type CustomerName(firstName, middleInitial, lastName) = 
  member _.FirstName = firstName 
  member _.MiddleInitial = middleInitial
  member _.LastName = lastName
  member _.AddOne x = x + 1


// "F# classes which are defined outside a module are generated as normal top-level .NET classes, which is probably what you want." modules are a static class
// https://fsharpforfunandprofit.com/posts/type-extensions/#downsides-of-methods
// "So, a plea for those of you new to functionally programming. Don't use methods at all if you can, especially when you are learning. 
// They are a crutch that will stop you getting the full benefit from functional programming."