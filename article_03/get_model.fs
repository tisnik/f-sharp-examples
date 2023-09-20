type car = {
    Color: string;
    Model: string;
    Manufacturer: string;
    Year: int;
}

let get_model car =
  match car with
  {Model = model} -> model

let toyota = {Color="silver"; Model="Corolla"; Manufacturer="Toyota"; Year=1986};;

printf "%s" (get_model toyota)
