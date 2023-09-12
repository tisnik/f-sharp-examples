let x = ref 42;;
Printf.printf "x=%d\n" !x;;

x := !x + 1;;
Printf.printf "x=%d\n" !x;;
