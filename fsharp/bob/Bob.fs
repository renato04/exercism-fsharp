module Bob
open System

let isYelling (input: string) =
    input 
    |> Seq.exists Char.IsLetter 
        && input |> Seq.exists Char.IsLower 
    |> not
 
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

let (|YellingQuestion|_|) (input: string)=
    if isYellingAQuestion input then
        Some("Calm down, I know what I'm doing!")
    else
        None

let (|Question|_|) (input: string)=
    if isQuestion input then
        Some("Sure.")
    else
        None

let (|Yelling|_|) (input: string)=
    if isYelling input then
        Some("Whoa, chill out!")
    else
        None

let (|SayingAnything|_|) (input: string)=
    if isSayingAnything input then
        Some("Fine. Be that way!")
    else
        None        

let response (input: string): string = 
    match input with
    | YellingQuestion answer -> answer
    | Question answer -> answer
    | Yelling answer -> answer
    | SayingAnything answer -> answer
    | _ -> "Whatever."