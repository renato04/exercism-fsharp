module Raindrops

let factors = [(3, "Pling"); (5, "Plang"); (7, "Plong")]

let convert (number: int): string = 
    factors
    |> List.filter (fun (factor, _) -> number % factor = 0)
    |> List.map snd
    |> function 
      | [] -> number.ToString ()
      | factors -> String.concat "" factors
