module BeerSong
open System

let (|WithMoreThanOne|_|) (value:int) =
    if value > 1 then
        Some WithMoreThanOne
    else
        None

let (|JustOne|_|) (value:int)  =
    if value = 1 then
        Some JustOne
    else
        None

let (|NoOne|_|) (value:int) =
    if value = 0 then
        Some NoOne
    else
        None             

let firsrVerse (bottles: int) =
    match bottles with
    | JustOne -> String.Format("{0} bottle of beer on the wall, {0} bottle of beer.", bottles)
    | NoOne -> "No more bottles of beer on the wall, no more bottles of beer."
    |_ -> String.Format("{0} bottles of beer on the wall, {0} bottles of beer.", bottles)

let secondVerse (bottles: int) =
    match bottles with
    | WithMoreThanOne -> 
        let remainder = bottles - 1
        match remainder with
        | JustOne -> String.Format("Take one down and pass it around, {0} bottle of beer on the wall.", remainder)
        | _ -> String.Format("Take one down and pass it around, {0} bottles of beer on the wall.", remainder)
    | JustOne ->   "Take it down and pass it around, no more bottles of beer on the wall."
    | NoOne -> "Go to the store and buy some more, 99 bottles of beer on the wall."
    | _ -> ""

let space (remainder: int) verse = 
    match remainder with
    | WithMoreThanOne | JustOne  -> [""] |> List.append verse
    | _ -> verse
   
let recite (startBottles: int) (takeDown: int) =
    let rec innerLopp remove acc =
        if remove = takeDown then
            acc
        else
            let nextRound = remove + 1
            let actual = startBottles - remove
            [
                firsrVerse actual
                secondVerse actual
            ]
            |> space (takeDown - nextRound)
            |> List.append acc
            |> innerLopp nextRound
            
    innerLopp 0 []
           
