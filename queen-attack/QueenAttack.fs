module QueenAttack

let create (position: int * int) = 
    let x, y = position
    not ((x < 0 || y < 0)  || (x > 7 || y > 7))

let isOnTheSameRow (queen1: int * int) (queen2: int * int) =
    let queen1Row = fst queen1
    let queen2Row = fst queen2

    queen1Row = queen2Row

let isOnTheSameColumn (queen1: int * int) (queen2: int * int) =
    let queen1Row = snd queen1
    let queen2Row = snd queen2

    queen1Row = queen2Row

let isOnDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1
    [
        for i in [1 .. 7] ->
            ((queen1Row - i), (queen1Column - i))
    ]
    |> List.append [
        for i in [1 .. 7] ->
            ((queen1Row - i), (queen1Column + i))
    ]
    |> List.append  [
        for i in [1 .. 7] ->
            ((queen1Row + i), (queen1Column - i))
    ]
    |> List.append [
        for i in [1 .. 7] ->
            ((queen1Row + i), (queen1Column + i))
    ]
    |> List.contains queen2

let canAttack (queen1: int * int) (queen2: int * int) = 
    (isOnTheSameColumn queen1 queen2) || (isOnTheSameRow queen1 queen2) ||
    (isOnDiagonal queen1 queen2)
    