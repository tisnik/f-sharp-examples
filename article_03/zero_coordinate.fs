let zero_coordinate point =
    match point with
    | (0, 0) | (0, _) | (_, 0) -> true
    | _ -> false
  
printf "%b" (zero_coordinate (0, 1))
printf "%b" (zero_coordinate (1, 0))
printf "%b" (zero_coordinate (0, 0))
printf "%b" (zero_coordinate (1, 1))
