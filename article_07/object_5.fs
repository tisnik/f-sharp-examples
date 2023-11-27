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



type Rectangle(x: int, y: int) =
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
