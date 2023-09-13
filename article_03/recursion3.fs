let fib n =
  let rec tailr i a b =
    if i = 0 then a else tailr (i-1) b (a + b)
  in
  tailr n 0 1;;

Printf.printf "%d" (fib 10)
