module KindergartenGarden

// TODO: define the Plant type
type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets

let charToPlant char =
    match char with
    | 'C' -> Clover
    | 'G' -> Grass
    | 'R' -> Radishes
    | _   -> Violets


let plants (diagram: string) (student: string) = 
    let diagrams = diagram.ToUpper().Split('\n')
    let position = (int (student.[0]) - int 'A') * 2
    
    [ 
        diagrams.[0].[position]; 
        diagrams.[0].[position + 1]; 
        diagrams.[1].[position]; 
        diagrams.[1].[position + 1]
    ] 
    |> List.map charToPlant