module Hamming

let hasSameSize (strand1: string) (strand2: string) =
   strand1.Length = strand2.Length

let sumDistance (strand1: string) (strand2: string) =
   (strand1, strand2)
   ||> Seq.zip 
   |> Seq.sumBy(fun (c1, c2) -> if c1 = c2 then 0 else 1)

let distance (strand1: string) (strand2: string): int option =
   if hasSameSize strand1 strand2 then
       Some(sumDistance strand1 strand2)
   else 
      None
      
    
