let inc x = x+1
let double x = x*2

let f1 = double >> inc >> double
printf "%d\n" (f1 1)
