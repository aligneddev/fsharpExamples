module Cards.Draw

// fill in 0 to 5
let cards = [ 0 .. 5 ]

// let drawCard (list:int list) = 
//     printfn "%i" list.Head
//     list.Tail

// // let result = cards |> drawCard |> drawCard // 0 1


let hand = []
let drawCardToHand (deck: list<int>, draw: list<int>) = 
    let firstCard = deck.Head
    printfn "%i" firstCard
    let hand = 
        draw
        |> List.append [firstCard]
    (deck.Tail, hand)

let deckAfter, handAfter = (cards, hand) |> drawCardToHand |> drawCardToHand
