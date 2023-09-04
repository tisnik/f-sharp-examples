let fib n =
  let rec tailr i a b =
    if i = 0 then a else tailr (pred i) b (a + b)
  in
  tailr n 0 1



fib 10
