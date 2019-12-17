module Bob
open System

let (|Question|_|) (input: string)=
    if input.Trim().EndsWith("?") then
        Some Question
    else
        None

let (|Yelling|_|) (input: string) =
    if input |> Seq.exists Char.IsLetter 
       && input |> Seq.exists Char.IsLower |> not then
        Some Yelling
    else
        None

let (|SayingAnything|_|) (input: string)=
    if String.IsNullOrWhiteSpace(input) then
        Some SayingAnything
    else
        None        

let response (input: string): string = 
    match input with
    | Yelling & Question -> "Calm down, I know what I'm doing!"
    | Question -> "Sure."
    | Yelling -> "Whoa, chill out!"
    | SayingAnything -> "Fine. Be that way!"
    | _ -> "Whatever."