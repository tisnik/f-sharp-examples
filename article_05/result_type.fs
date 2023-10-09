type Result<'T,'TError> =
    | Ok of ResultValue:'T
    | Error of ErrorValue:'TError
