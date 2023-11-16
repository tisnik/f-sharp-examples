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



let rec even x =
  if x = 0
  then true
  else odd (x-1)
and odd x =
  if x = 0
  then false
  else even (x-1)


printf "%b" (even 1)
printf "%b" (even 2)
printf "%b" (even 3)
printf "%b" (even 4)
