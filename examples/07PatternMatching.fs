//examples from  https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching
module fsharpExamples.PatternMatching

// match expression with
// | pattern [ when condition ] -> result-expression
// ...

type Color =
    | Red = 0
    | Green = 1
    | Blue = 2

let printColorName (color:Color) =
    match color with
    | Color.Red -> printfn "Red"
    | Color.Green -> printfn "Green"
    | Color.Blue -> printfn "Blue"
    | _ -> ()

printColorName Color.Red
printColorName Color.Green
printColorName Color.Blue


// many more