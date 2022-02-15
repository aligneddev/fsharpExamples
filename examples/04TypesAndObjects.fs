// aka a record
// Records are essentially sealed classes with extra topping: default immutability, structural equality, and pattern matching support.
// https://github.com/adelarsq/fsharp-cheatsheet#TypesAndLiterals

module fSharpExamples.TypesAndObjects

type Person = 
  { 
    name : string
    hobbies : string list 
  }
  static member Empty = 
    // doesn't compile { name = "", hobbies = [] }
    { 
      name = ""
      hobbies = [] 
    }

let Kevin2 =
  { 
    Person.Empty with 
      name = "Kevin"
      hobbies = ["guitar"; "biking"; "reading"]
  }
let Kevin3 = {
  name = "Kevin"
  hobbies = ["guitar"; "biking"; "reading"]
}

let Joey  = { 
  Person.Empty with 
    name = "Joey"
}


// classes are different
// https://fsharpforfunandprofit.com/posts/classes/
// created with a ctor, have () after the class name
// You could use "this" or "self" or "me" or any other word that commonly indicates a self reference.
type CustomerName(firstName:string, middleInitial, lastName) = 
  member _.FirstName = firstName 
  member _.MiddleInitial = middleInitial
  member _.LastName = lastName
  member _.AddOne x = x + 1

let customer = CustomerName("Kurt", "M", "Woolworth")
// immutable customer.LastName <- "kjkl";

// "F# classes which are defined outside a module are generated as normal top-level .NET classes, which is probably what you want." modules are a static class
// https://fsharpforfunandprofit.com/posts/type-extensions/#downsides-of-methods
// "So, a plea for those of you new to functionally programming. Don't use methods at all if you can, especially when you are learning. 
// They are a crutch that will stop you getting the full benefit from functional programming."


// Tuples
// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/tuples

// let t = ("one", "two", "three")