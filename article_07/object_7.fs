type Vector(x: int, y: int) =
    member this.X = x
    member this.Y = y
    member this.Print() =
        printf "Vector: %dx%d\n" this.X this.Y
    static member inline (+) (a : Vector, b : Vector) =
        Vector(a.X + b.X, a.Y + b.Y)

let v1 = Vector(10, 20)
v1.Print()

let v2 = Vector(1, 2)
v2.Print()

let v3 = v1 + v2
v3.Print()
