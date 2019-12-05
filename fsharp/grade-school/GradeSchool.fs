module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty 

let grade (number: int) (school: School): string list = 
    school
    |> Map.tryFind number
    |> Option.defaultValue []
    
let add (student: string) (studentGrade: int) (school: School): School = 
    let addTo school grade students = 
        Map.add grade students school

    let addStudent = addTo school studentGrade
    
    school
    |> grade studentGrade
    |> List.append [student]
    |> List.sort
    |> addStudent

let roster (school: School): string list =
    school
    |> Map.toList
    |> List.collect snd

