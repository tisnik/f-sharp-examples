let sub x y = x-y
let swap x y = (y, x)

let x = (1, 2) ||> sub
printf "%d\n" x

let y = (1, 2) ||> swap ||> sub
printf "%d\n" y
