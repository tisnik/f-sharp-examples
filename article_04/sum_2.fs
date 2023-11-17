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



let sum x =
    let rec sumr x a =
        match x with
        | [] -> a
        | head :: tail -> sumr tail (a + head)
    sumr x 0

printf "%d" (sum [])
printf "%d" (sum [1; 2; 3])
