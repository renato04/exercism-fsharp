module TwoFer
open System

let twoFer (input: string option): string =
    input
    |> Option.defaultValue "you" input
    |> sprintf "One for %s, one for me."