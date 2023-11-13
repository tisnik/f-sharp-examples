type Shape() =
    member this.Print() = ()
           
type Rectangle(x: int, y: int) =
    inherit Shape()
    member this.X = x
    member this.Y = y
    member this.Print() =
        printf "Rectangle: %dx%d\n" this.X this.Y
    member this.Enlarge(dx, dy) =
        Rectangle(this.X + dx, this.Y + dy)

let r1 = Rectangle(10, 20)
r1.Print()

let r2 = r1.Enlarge(1, 2)
r2.Print()
