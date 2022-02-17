

let isDivisibleBy divisor num =
    num % divisor = 0

let divisibleByFour num =
    isDivisibleBy 4 num
    
let divisibleByOneHundred num=
    isDivisibleBy 100 num
    
let divisibleByFourHundred num =
    isDivisibleBy 400 num
    
let Check num = 
   divisibleByFour num && not (divisibleByOneHundred num) || ( divisibleByFourHundred num)  
   