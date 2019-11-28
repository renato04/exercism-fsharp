module Pangram

let isPangram (input: string): bool = 
    let verifyLength length=
        let alphabetSize = 26
        length = alphabetSize
        
    input.Trim().ToLower()
    |> Seq.filter (fun c -> System.Char.IsLetter(c))
    |> Seq.distinct
    |> Seq.length
    |> verifyLength