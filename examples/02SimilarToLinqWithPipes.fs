// send to F# Interactive with highlight + Alt + Enter
// or Open the Command Palette with Ctrl+Shift+P and find FSI: Start command (requires Ionide extension)
// https://stackoverflow.com/questions/56425674/how-to-enable-f-interactive-in-visual-studio-code

// referenced in Program.fs
module fSharpExamples.Linq

// whitespace to the left matters
let getOddSquares xs =
    xs
    |> List.filter (fun x -> x % 2 <> 0)
    |> List.map (fun x -> x * x)

// compare to C#
// var xs = new List<int>{ 1, 2, 3, 4, 5, 6};
// var results = xs.Where(x => x % 2 != 0).Select(x => x * x);

