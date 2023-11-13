type Shape() =
    member this.Print() = printf "Shapeless shape"
           
type Circle(r: int) =
    inherit Shape()
    member this.R = r
    member this.Print() =
        printf "Circle: %d\n" this.R
    member this.Enlarge(dr) =
        Circle(this.R + dr)

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

let c1 = Circle(10)
c1.Print()

let c2 = c1.Enlarge(1)
c2.Print()

let s1 = r1 :> Shape
s1.Print()
