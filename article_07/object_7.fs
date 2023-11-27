(*
    (C) Copyright 2023  Pavel Tisnovsky

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*)



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
