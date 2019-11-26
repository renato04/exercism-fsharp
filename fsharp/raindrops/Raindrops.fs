module Raindrops

let factors = Map.empty.
                Add(3, "Pling").
                Add(5, "Plang").
                Add(7, "Plong")

let convert (number: int): string = 
    factors
    |> Map.filter (fun factor _ -> number % factor = 0)
    |> (fun factors -> 
            if Map.isEmpty factors then 
                number.ToString()
            else
                Map.fold (fun state _ value -> state + value) "" factors
       ) 