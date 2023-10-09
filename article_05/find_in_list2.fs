let rec find list value =
    match list with
    | head :: tail -> if head = value then Some(head) else find tail value
    | [] -> None

let print_item value =
    match value with
    | Some(x) -> printf "%d" x
    | None -> printf "not found"

let list1 = [1; 2; 3; 4]
let list2 = [0; 0; 0; 0]
let list3 = []
let list4 = [3]

print_item (find list1 3)
print_item (find list2 3)
print_item (find list3 3)
print_item (find list4 3)
