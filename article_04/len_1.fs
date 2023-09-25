(* Naivní implementace funkce length *)

let rec len (x:'a list) =
    if x.IsEmpty then 0
    else 1 + (len x.Tail)

printf "%d" (len [1;2;3;4])
