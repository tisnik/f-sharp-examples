let divide x y =
    match y with
    | 0 -> Error "divide by zero"
    | _ -> Ok (x/y)

printf "%A\n" (divide 10 2)
printf "%A\n" (divide 10 0)
