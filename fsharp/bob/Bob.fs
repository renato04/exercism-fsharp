module Bob
open System

let isYelling (input: string) =
    let rec innerLoop isUpper array =
        match array with
        | [] -> isUpper
        | head :: tail -> 
            match Char.IsLower(head) with
            | true -> innerLoop false []
            | false -> innerLoop true tail

    input
    |> Seq.filter (fun s -> Char.IsLetter(s))
    |> Seq.toList
    |> innerLoop false

let isQuestion (phrase: string) =
    let validPhrase = phrase.Trim().ToCharArray()
    match validPhrase with
    | [||] -> false
    | _ -> (validPhrase |> Seq.last) = '?'
         
let isYellingAQuestion (phrase: string) =
    isYelling phrase &&  isQuestion phrase

let isSayingAnything (phrase: string) =
    phrase.Trim()
    |> String.IsNullOrEmpty
   
let response (input: string): string = 
    match input with
    | _ when isYellingAQuestion input -> "Calm down, I know what I'm doing!"
    | _ when isQuestion input -> "Sure."
    | _ when isYelling input -> "Whoa, chill out!"
    | _ when isSayingAnything input -> "Fine. Be that way!"
    | _ -> "Whatever."