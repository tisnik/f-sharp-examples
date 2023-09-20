let rec gcd a b = 
    match a, b with
    | (a,0) -> a
    | (a,b) -> gcd b (a % b)


printf "%d" (gcd 12 8)