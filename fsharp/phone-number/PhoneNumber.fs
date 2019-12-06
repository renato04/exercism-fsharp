module PhoneNumber

open System.Text.RegularExpressions

let validateDigitOnly input =
    let matchesLetter = Regex.Match(input, @"[a-z]").Success
    let matchesPunctuation = Regex.Match(input, @"[@:\!]").Success
    if matchesLetter then Error "letters not permitted"
    elif matchesPunctuation then Error "punctuations not permitted"
    else Ok input


let validateLength (digits: string) =
    let length = digits.Length
    if length < 10 then
        Error "incorrect number of digits"
    elif length > 11 then
        Error "more than 11 digits"
    elif length = 11 then
        if digits.[0] <> '1' then Error "11 digits must start with 1"
        else Ok digits.[1..]
    else
        Ok digits

let validateCode (digits: string) =
    let areaCode = digits.[0]
    let exchangeCode = digits.[3]
    if areaCode = '0' then Error "area code cannot start with zero"
    elif areaCode = '1' then Error "area code cannot start with one"
    elif exchangeCode = '0' then Error "exchange code cannot start with zero"
    elif exchangeCode = '1' then Error "exchange code cannot start with one"
    else Ok digits



let clean =
    validateDigitOnly
    >> Result.map (fun x -> Regex.Replace(x, @"\D", ""))
    >> Result.bind validateLength
    >> Result.bind validateCode
    >> Result.map uint64