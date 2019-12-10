module Clock

let MinutesPerDay = 1440

let MinutesPerMinute = 60

let private normalize clock =
    let processNegative =
        let completeNegativeDays = -clock / MinutesPerDay
        clock + (1 + completeNegativeDays) * MinutesPerDay
    
    if clock < 0 then
        processNegative
    else
        clock % MinutesPerDay

let create hours minutes = 
    (hours * MinutesPerMinute + minutes) 
    |> normalize

let add minutes clock = 
    minutes + clock 
    |> normalize

let subtract minutes clock = 
    add (-minutes) clock 
    |> normalize

let minutes clock = clock % MinutesPerMinute

let hours clock = clock / MinutesPerMinute

let display clock = sprintf "%02d:%02d" (hours clock) (minutes clock)