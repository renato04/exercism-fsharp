module Raindrops

let factors = [(3, "Pling"); (5, "Plang"); (7, "Plong")]

let convert (number: int): string = 
    let getResponse factors =
        if List.isEmpty factors then 
            number.ToString()
        else
            List.fold (fun state value -> state + snd value) "" factors
    
    factors
    |> List.filter (fun factor -> number % fst factor = 0)
    |> getResponse