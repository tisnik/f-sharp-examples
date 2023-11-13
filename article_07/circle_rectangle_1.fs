type Shape = Rectangle of int * int | Circle of int

let print_shape (s : Shape) =
    match s with
    | Circle r -> printf "circle: %d\n" r
    | Rectangle (width, height) -> printf "rect: %dx%d\n" width height

let r1 = Rectangle (10, 20)
let c = Circle 100

print_shape r1
print_shape c
