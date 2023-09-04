(* Implementace funkce length založená na pattern matchingu *)

fun length([]) = 0
  | length(_::tail) = 1 + length(tail);
