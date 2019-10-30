module QueenAttack

let create (position: int * int) = 
    match position with
    |(x, y) when (x < 0 || y < 0)  || (x > 7 || y > 7) -> false
    |(_, _) -> true

let isOnTheSameRow (queen1: int * int) (queen2: int * int) =
    let queen1Row = fst queen1
    let queen2Row = fst queen2

    queen1Row = queen2Row

let isOnTheSameColumn (queen1: int * int) (queen2: int * int) =
    let queen1Row = snd queen1
    let queen2Row = snd queen2

    queen1Row = queen2Row

let isOnUpperLeftDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1

    let diagonal = [
        for i in [1 .. 7] ->
            ((queen1Row - i), (queen1Column - i))
    ]

    diagonal
    |> List.contains queen2

let isOnUpperRightDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1

    let diagonal = [
        for i in [1 .. 7] ->
            ((queen1Row - i), (queen1Column + i))
    ]

    diagonal
    |> List.contains queen2

let isOnDownLeftDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1

    let diagonal = [
        for i in [1 .. 7] ->
            ((queen1Row + i), (queen1Column - i))
    ]

    diagonal
    |> List.contains queen2

let isOnDownRightDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1

    let diagonal = [
        for i in [1 .. 7] ->
            ((queen1Row + i), (queen1Column + i))
    ]

    diagonal
    |> List.contains queen2



let isOnTheSameDiagonal (queen1: int * int) (queen2: int * int) = 
    (isOnUpperLeftDiagonal queen1 queen2) || (isOnUpperRightDiagonal queen1 queen2) ||
    (isOnDownLeftDiagonal queen1 queen2) || (isOnDownRightDiagonal queen1 queen2)

let canAttack (queen1: int * int) (queen2: int * int) = 
    (isOnTheSameColumn queen1 queen2) || (isOnTheSameRow queen1 queen2) ||
    (isOnTheSameDiagonal queen1 queen2)
    