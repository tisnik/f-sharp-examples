type Rectangle = int * int

let print_rectange r =
    let (width, height) = r in
        printf "rect: %dx%d\n" width height

let r1 = (10, 20)

print_rectange r1
