let rec ackermann m n =
  match m, n with
  | (m,n) when m < 0 || n < 0 -> invalidArg "input" "Ackermann's function is only defined over the non-negative integers"
  | (0,n) -> n+1
  | (m,0) -> ackermann (m-1) 1
  | (m,n) -> ackermann (m-1) (ackermann m (n-1))

printf "%d" (ackermann 2 10)
printf "%d" (ackermann -2 10)
