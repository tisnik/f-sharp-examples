(* Implementace funkce append založená na pattern matchingu *)
 
let rec append x y =
    match x with
    | [] -> y
    | head :: tail -> head :: append tail y


printf "%A" (append [] [1; 2; 3])
printf "%A" (append [1; 2; 3] [])
printf "%A" (append [1; 2; 3] [4; 5])
printf "%A" (append [] [])
