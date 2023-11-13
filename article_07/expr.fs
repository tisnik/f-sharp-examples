type expr =
    | Plus of expr * expr        (* a + b *)
    | Minus of expr * expr       (* a - b *)
    | Times of expr * expr       (* a * b *)
    | Divide of expr * expr      (* a / b *)
    | Var of string    

let x = Times (Var "n", Plus (Var "x", Var "y"))

printf "%A\n" x
