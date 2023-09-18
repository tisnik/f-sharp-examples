let rec factorial n =
    match n with
    | 0 -> 1
    | 1 -> 1
    | _ -> n * factorial(n-1)

printf "%d" (factorial 10)
