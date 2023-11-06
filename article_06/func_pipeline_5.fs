let madd x y z = x*y+z

let x = (3, 2, 1) |||> madd
printf "%d\n" x
