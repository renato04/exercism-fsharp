open System
open BookStore

[<EntryPoint>]
let main argv =
    System.Console.WriteLine(total [1; 1; 2; 2; 3; 3; 4; 5])
    |>ignore

    0