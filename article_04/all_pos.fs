let rec all_pos x =
    match x with
    | [] -> false
    | [x] -> x > 0
    | head :: tail -> head > 0 && all_pos tail

printf "%b" (all_pos [])
printf "%b" (all_pos [1; 2; 3])
printf "%b" (all_pos [-1; 2; 3])
printf "%b" (all_pos [1; 2; -3])
