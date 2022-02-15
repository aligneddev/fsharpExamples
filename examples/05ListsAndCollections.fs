// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists
// https://docs.microsoft.com/en-us/learn/modules/fsharp-lists/2-collection
// Lists - ordered, immutable, linked list
// Arrays - fixed-size, mutable (perf hit)
// Sequences - a logical series of elements of the same type, large collections, 
    // don't expect to use all of them, only computes when required, sometimes ^ perf than lists
module fSharpExamples.ListsAndCollections

let cards = ["Ace"; "King"; "Queen"]
let newList = "Jack" :: cards

type stuff = { 
    // mutable listOfStuff: string list
    listOfStuff: string list
    name: string 
  }
let s = { 
    listOfStuff = ["corn"; "dog"]
    name = "S"
  }

// assignment with <- , immutable
//s.listOfStuff <- ["a"]

// or  let newList =  cards |> List.append ["Jack"]

// access by index 
let first = newList.Item 1 
let first2 = newList.Head // same as first
let last = newList.Tail // all but first



// last line is the "return"
