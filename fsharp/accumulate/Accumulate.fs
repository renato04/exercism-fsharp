module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec innerLoop res =
        function
        | head :: tail -> innerLoop (func head :: res) tail
        | [] -> res
    innerLoop [] input |> List.rev
