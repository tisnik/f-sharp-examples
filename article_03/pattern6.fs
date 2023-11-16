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



let rec ackermann m n =
  match m, n with
  | (m,n) when m < 0 || n < 0 -> invalidArg "input" "Ackermann's function is only defined over the non-negative integers"
  | (0,n) -> n+1
  | (m,0) -> ackermann (m-1) 1
  | (m,n) -> ackermann (m-1) (ackermann m (n-1))

printf "%d" (ackermann 2 10)
printf "%d" (ackermann -2 10)
