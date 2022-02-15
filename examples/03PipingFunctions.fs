// code from https://docs.microsoft.com/en-us/learn/modules/fsharp-functions/, you should go through the tutorial
module fSharpExamples.Piping

printfn "03PipingFunctions"

// simple example of functions and piping
let myList = [4; 3; 1]
let myListLetters = ["a"; "b"; "c"]
let sort (list: int list) = List.sort list
let print (list)= List.iter(fun x-> printfn $"item {x}") list
let listSortPrint = myList |> sort |> print

// typing of int list stops this
// let listSortPrint2 = myListLetters |> sort |> print

open Cards.Shuffle
cards |> shuffle |> take 3 |> printAll

open Cards.Draw
printfn "Deck: %A Hand: %A" deckAfter handAfter


// function composition example
// let add2 a = a + 2
// let multiply3 a = a * 3 
// let addAndMultiply = add2 >> multiply3

// printfn "%i" (addAndMultiply 2) // 12