module WordCount
open System.Text.RegularExpressions

let countWords (phrase: string) =
    let getValidValues (value: string) =
        Regex.Matches(value.ToLowerInvariant(), @"\b[\w']+\b")
    
    phrase
    |> getValidValues
    |> Seq.map (fun x -> x.Value)
    |> Seq.countBy id
    |> Map.ofSeq