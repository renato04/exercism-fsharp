module QueenAttack

let create (position: int * int) = 
    let isInRange x = x >= 0 && x <= 7
    let x, y = position
    isInRange x && isInRange y

let isOnTheSameRow (queen1: int * int) (queen2: int * int) =
    let queen1Row = fst queen1
    let queen2Row = fst queen2

    queen1Row = queen2Row

let isOnTheSameColumn (queen1: int * int) (queen2: int * int) =
    let queen1Column = snd queen1
    let queen2Column = snd queen2

    queen1Column = queen2Column

let isOnDiagonal (queen1: int * int) (queen2: int * int) =
    let queen1Row, queen1Column = queen1
    let queen2Row, queen2Column = queen2
    abs (queen1Row - queen2Row) = abs (queen1Column - queen2Column)

let canAttack (queen1: int * int) (queen2: int * int) = 
    isOnTheSameColumn queen1 queen2 
    || isOnTheSameRow queen1 queen2 
    || isOnDiagonal queen1 queen2
    