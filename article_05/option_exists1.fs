let exists x =
    match x with
    | Some(x) -> true
    | None -> false

let maybeAnswer1 = Some 42
let maybeAnswer2 = None

printf "%b" (exists maybeAnswer1)
printf "%b" (exists maybeAnswer2)
