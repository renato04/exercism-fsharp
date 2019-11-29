module Raindrops

let factors = [(3, "Pling"); (5, "Plang"); (7, "Plong")]

let convert (number: int): string = 
    let getResponse factors =
        if List.isEmpty factors then 
            number.ToString()
        else
            String.concat "" factors    
    factors
    |> List.filter (fun (factor, _) -> number % factor = 0)
    |> List.map  (fun (_, output) -> output)
    |> getResponse