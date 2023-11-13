type Rectangle(x: int, y: int) =
    let area = x * y
    member this.X = x
    member this.Y = y
    member this.Print() =
        printf "Rectangle: %dx%d %d\n" x y area

let r1 = Rectangle(10, 20)
let r2 = Rectangle(1, 2)

printf "%d\n" r1.X
printf "%d\n" r1.Y

printf "%d\n" r2.X
printf "%d\n" r2.Y
