module Isogram
open System

let isIsogram str = 
    let getOnlyLetters =
        str
        |> Seq.filter Char.IsLetter
        |> Seq.map Char.ToLower

    Seq.length getOnlyLetters = (Seq.distinct getOnlyLetters |> Seq.length)