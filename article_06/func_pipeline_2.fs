let inc x = x+1
let double x = x*2

let x = double <| (inc <| 10)
printf "%d\n" x
