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



let exists x =
    match x with
    | Some(x) -> true
    | None -> false

let maybeAnswer1 = Some 42
let maybeAnswer2 = None

printf "%b" (exists maybeAnswer1)
printf "%b" (exists maybeAnswer2)
