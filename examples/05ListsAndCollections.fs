// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists
module fSharpExamples.ListsAndCollections


let cards = ["Ace"; "King"; "Queen"]
let newList = "Jack" :: cards

// or  let newList =  cards |> List.append ["Jack"]

// access by index 
let first = newList.Item 1 
