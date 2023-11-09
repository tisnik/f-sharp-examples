type User = 
    { ID: int
      Name: string
      Surname: string}

type UserWithoutID = 
    { Name: string
      Surname: string}

let print_name (x:User) =
    printf "%s %s" x.Name x.Surname

let pepa =
    { ID = 42
      Name = "Josef"
      Surname = "Vyskočil"}


(* funkcni varianta *)
print_name pepa
