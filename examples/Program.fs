// For more information see https://aka.ms/fsharp-console-apps
open System

printfn "Hello from F#"

open fSharpExamples.Linq
printfn "getOddSquares: %A" (getOddSquares([1..10]))

open fSharpExamples.Piping
// once I uncomment this, it will run all the functions in Piping
// let myList = [123; 33; 22]
// printfn "03PipingFunctions in Program"
// listSortPrint

