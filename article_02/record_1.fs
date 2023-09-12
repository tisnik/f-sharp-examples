type car = {
    Color: string;
    Model: string;
    Manufacturer: string;
    Year: int;
}

let toyota :car = {Color="silver"; Model="Corolla"; Manufacturer="Toyota"; Year=1986};;

Printf.printf "%A" toyota
