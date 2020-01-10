module KindergartenGarden
open System

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
    | 'V'  -> Violets
    | _ -> failwith "Invalid Character"


let plants (diagram: string) (student: string) = 


    let position = (int (student.[0]) - int 'A') * 2

    diagram.ToUpper().Split('\n')
    |> Seq.collect (fun diagram -> [diagram.[position]; 
        diagram.[position + 1]; ] )
    // [ 
    //     diagrams.[0].[position]; 
    //     diagrams.[0].[position + 1]; 
    //     diagrams.[1].[position]; 
    //     diagrams.[1].[position + 1]
    // ] 
    |> Seq.map charToPlant
    |> Seq.toList