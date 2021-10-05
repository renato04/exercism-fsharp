module Pangram

let isPangram (input: string): bool = 
    let verifyLength length=
        let alphabetLength = 26
        length = alphabetLength
        
    input.Trim().ToLower()
    |> Seq.filter (fun c -> System.Char.IsLetter(c))
    |> Seq.distinct
    |> Seq.length
    |> verifyLength