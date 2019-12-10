module BookStore
open System

let price bs =
    let discount = 
        match Set.count bs with
        | 5 -> 0.75m
        | 4 -> 0.80m
        | 3 -> 0.90m
        | 2 -> 0.95m
        | _ -> 1.00m
    8m * (decimal bs.Count) * discount

let calculateTotalPrice sets = 
    (List.map price >> List.sum) sets

let rec drop e l =
    match l with
    | [] -> []
    | x::xs when x = e -> xs
    | x::xs -> x::(drop e xs)

let findBestSplit books =
    List.fold (fun sets b ->
        let setsWithoutBook = List.where (Set.contains b >> not) sets 
        match setsWithoutBook with
        | [] -> Set.empty.Add(b)::sets
        | _ -> 
            let rest = List.where (Set.contains b) sets
            let bestSet = 
                setsWithoutBook
                |> List.fold (fun candidateSets set -> 
                    ((Set.add b set)::(drop set setsWithoutBook))::candidateSets) [] 
                |> List.minBy calculateTotalPrice
            List.append bestSet rest
    ) [] books

let sortByOccurence books =
    books
    |> List.groupBy id
    |> List.map snd
    |> List.sortByDescending List.length
    |> List.concat

let total books = 
    (sortByOccurence >> findBestSplit >> calculateTotalPrice) books

