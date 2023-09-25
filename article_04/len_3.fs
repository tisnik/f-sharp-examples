(* Méně naivní implementace funkce length *)

let rec len x =
    match x with
    | _ :: tail -> 1 + len tail
    | [] -> 0

printf "%d" (len [1;2;3;4])
