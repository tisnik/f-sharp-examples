type Rectangle = int * int

let print_rectange (r : Rectangle) =
    match r with
    | (width, height) -> printf "rect: %dx%d\n" width height

let r1 = (10, 20)

print_rectange r1
