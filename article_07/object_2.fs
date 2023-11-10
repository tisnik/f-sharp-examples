type Rectangle(x: int, y: int) =
    member this.X = x
    member this.Y = y
    member this.Print() =
        printf "Rectangle: %dx%d\n" x y

let r1 = Rectangle(10, 20)

r1.Print()
