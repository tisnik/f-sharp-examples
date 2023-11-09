type Rectangle = Rectangle of int * int

let print_rectange (r : Rectangle) =
    match r with
    | Rectangle(width, height) -> printf "rect: %dx%d\n" width height

let r1 = Rectangle(10, 20)

print_rectange r1
