type Rectangle = R of int * int

let print_rectange (r : Rectangle) =
    match r with
    | R(width, height) -> printf "rect: %dx%d\n" width height

let r1 = R(10, 20)

print_rectange r1
