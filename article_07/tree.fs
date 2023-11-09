type Tree<'a> =
    | E
    | T of Tree<'a> * 'a * Tree<'a>

let t1 = T(E, "foo", E)
let t2 = T(T(E, "foo", E), "bar", T(E, "baz", E))

printf "%A\n" t1

printf "%A\n" t2
