let x = ref 42
printf "x=%d\n" x.Value

x.Value <- x.Value + 1
printf "x=%d\n" x.Value
