let rec find list value =
    match list with
    | head :: tail -> if head = value then Some(head) else find tail value
    | [] -> None

let list1 = [1; 2; 3; 4]
let list2 = [0; 0; 0; 0]
let list3 = []
let list4 = [3]

printf "%A" (find list1 3)
printf "%A" (find list2 3)
printf "%A" (find list3 3)
printf "%A" (find list4 3)
