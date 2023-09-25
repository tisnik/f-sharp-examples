let sum x =
    let rec sumr x a =
        match x with
        | [] -> a
        | head :: tail -> sumr tail (a + head)
    sumr x 0

printf "%d" (sum [])
printf "%d" (sum [1; 2; 3])
