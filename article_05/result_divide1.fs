let divide (x:int) (y:int) =
    match y with
    | 0 -> Error "divide by zero"
    | _ -> Ok (x/y)

printf "%A\n" (divide 10 2)
printf "%A\n" (divide 10 0)
