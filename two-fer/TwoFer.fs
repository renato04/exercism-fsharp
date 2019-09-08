module TwoFer
open System

let twoFer (input: string option): string =
    if input.IsSome
    then sprintf "One for %s, one for me." input.Value
    else "One for you, one for me."