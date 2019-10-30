module Leap

let isDivisbleBy4 (year: int) = 
    year % 4 = 0

let isDivisbleBy100 (year: int) =
    year % 100 = 0
   
let isDivisbleBy400 (year: int) =
    year % 400 = 0 

let leapYear (year: int): bool = 
    isDivisbleBy4(year) && (not (isDivisbleBy100(year))) || isDivisbleBy400(year)
