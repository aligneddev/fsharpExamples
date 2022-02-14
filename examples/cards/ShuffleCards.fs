// https://docs.microsoft.com/en-us/learn/modules/fshaarp-functions/5-exercise-patterns
module Cards.Shuffle

let cards = [21; 3; 1; 7; 9; 23]

// cardFace is a function that takes in card which is inferred as an int and the returned as a string
let cardFace card = 
    let no = card % 13
    if no = 1 then "Ace"
    elif no = 0 then "King"
    elif no = 12 then "Queen"
    elif no = 11 then "Jack"
    else string no

let suit card =
    let no = card / 13
    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = System.Random()
    list |> List.sortBy (fun x -> random.Next())

printfn "Cards.Shuffle"

// printCard is a function that takes in card
let printCard card = printfn "%s of %s" (cardFace card) (suit card)

let printAll list = List.iter(fun x -> printCard(x)) list

let take (number:int) (list) = List.take number list
