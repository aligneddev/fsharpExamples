// code from https://docs.microsoft.com/en-us/learn/modules/fsharp-functions/
module fSharpExamples.Piping

printfn "03PipingFunctions"

// simple example of functions and piping
let list = [4; 3; 1]
let sort (list: int list) = List.sort list
let print (list: int list)= List.iter(fun x-> printfn "item %i" x) list

let listSortPrint = list |> sort |> print

open Cards.Shuffle
cards |> shuffle |> take 3 |> printAll

open Cards.Draw
printfn "Deck: %A Hand: %A" d h