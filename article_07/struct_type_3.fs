type User = 
    { ID: int
      Name: string
      Surname: string}

let print_user x =
    printf "%s %s" x.Name x.Surname

let pepa =
    { ID = 42
      Name = "Josef"
      Surname = "Vyskočil"}


print_user pepa
