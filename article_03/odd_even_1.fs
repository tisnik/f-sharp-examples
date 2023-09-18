let even x =
  if x = 0
  then true
  else odd (x-1)

let odd x =
  if x = 0
  then false
  else even (x-1)


printf "%b" (even 1)
printf "%b" (even 2)
printf "%b" (even 3)
printf "%b" (even 4)
