let x = [1; 2; 3]
let y = [1..10]
let z = x @ y

printf "list:   %A" z
printf "empty?: %b" z.IsEmpty
printf "length: %d" z.Length
printf "head:   %A" z.Head
printf "tail:   %A" z.Tail
printf "item 3: %A" (z.Item 3)
