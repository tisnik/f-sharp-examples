let rec factorial n =
    match n with
    | n when n < 0 -> invalidArg "input" "non-negative integer expected"
    | 0 | 1 -> 1
    | _ -> n * factorial(n-1)

printf "%d" (factorial 10)
printf "%d" (factorial -10)
