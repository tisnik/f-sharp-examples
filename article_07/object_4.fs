type Rectangle(x: int, y: int) =
    let area = x * y
    member this.X = x
    member this.Y = y
    member this.Print() =
        printf "Rectangle: %dx%d with area %d\n" this.X this.Y area

let r1 = Rectangle(10, 20)

r1.Print()
