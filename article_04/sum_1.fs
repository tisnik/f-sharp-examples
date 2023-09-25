let rec sum x =
    match x with
    | [] -> 0
    | head :: tail -> head + sum tail

printf "%d" (sum [])
printf "%d" (sum [1; 2; 3])
