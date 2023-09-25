(* Naivní implementace funkce append *)
 
let rec append (x: 'a list) y =
    if x.IsEmpty then y
    else x.Head :: (append x.Tail y)


printf "%A" (append [] [1; 2; 3])
printf "%A" (append [1; 2; 3] [])
printf "%A" (append [1; 2; 3] [4; 5])
printf "%A" (append [] [])
