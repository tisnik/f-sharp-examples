let a = [| 1; 2; 3; 4; |];;
printf "%A" a

a.[0] <- 42;; 
printf "%A" a

a.[1] <- 6502;;
printf "%A" a
