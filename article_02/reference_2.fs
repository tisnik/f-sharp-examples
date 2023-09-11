let x = ref 42
Printf.printf "x=%d\n" x.Value

x.Value <- x.Value + 1
Printf.printf "x=%d\n" x.Value
