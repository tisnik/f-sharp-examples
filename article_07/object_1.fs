type Rectangle(x: int, y: int) =
    member this.X = x
    member this.Y = y


let r1 = Rectangle(10, 20)

printf "%A\n" r1
