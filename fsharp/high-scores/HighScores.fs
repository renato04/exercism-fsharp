module HighScores

let scores (values: int list): int list = 
    values

let latest (values: int list): int = 
    values
    |> List.filter (fun value -> value > 0)
    |> List.min

let personalBest (values: int list): int = 
    values
    |> List.max

let personalTopThree (values: int list): int list = 
    values
    |> List.sortDescending
    |> (fun l -> 
        if List.length l < 3 then
            l
        else
            l
            |> List.take  3
    )
    
