printfn "Hello World!"

// ;; to exit in the command line
// dotnet fsi 01HellowWorldRepl.fsx
// VS Code alt + shift + p start FSI
// or highlight and Alt + Enter in VS Code
// "unit is a value that acts as a placeholder when no actual value is returned. You can think of it like void or None."

// let <function name> <parameters> = <function body>
// Be explicit let convert (a:string) :int = int a, but it could just be let convert a = int a


// // add a package to your repl
// #r "nuget: FSharp.Data"
// // https://github.com/dsyme/guido-learns-fsharp/blob/e6a318a4d72fc73fee6bc31d79398cd6b3f1701a/playground.fsx
// // https://yukitos.github.io/FSharp.Data/library/JsonProvider.html
// open FSharp.Data 
// type WikipediaIO = JsonProvider<"http://api.geonames.org/findNearbyWikipediaJSON?lat=52.3676&lng=4.9041&username=dsyme">

// // Task 5.5 - Use the JsonProvider to download the data, the code is below
// let info =
//     $"http://api.geonames.org/findNearbyWikipediaJSON?lat=52.3676&lng=4.9041&username=dsyme"
//     |> WikipediaIO.AsyncLoad
//     |> Async.RunSynchronously

// // another way: let info = WikipediaIO.Load "http://api.geonames.org/findNearbyWikipediaJSON?lat=52.3676&lng=4.9041&username=dsyme"



// // Task 5.6 - Extract the title, latitude, longitude and summary for each result
// [ for x in info.Geonames -> x.Title, x.Lat, x.Lng, x.Summary ]



