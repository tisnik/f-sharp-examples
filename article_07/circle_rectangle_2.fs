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



type Shape = 
    | Circle of int
    | Rectangle of int * int

let print_shape (s : Shape) =
    match s with
    | Circle r -> printf "circle: %d\n" r
    | Rectangle (width, height) -> printf "rect: %dx%d\n" width height

let r1 = Rectangle (10, 20)
let c = Circle 100

print_shape r1
print_shape c
