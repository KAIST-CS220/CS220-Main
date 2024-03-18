/// KAIST CS220 In-Class Activity Project

let car lst =
  match lst with
  | hd :: _ -> hd
  | _ -> failwith "Empty list is given."

let cdr lst =
  match lst with
  | _ :: tl -> tl
  | _ -> failwith "Empty list is given."

/// Modify this function to return the last element of the given list.
let last lst =
  failwith "Implement"

/// Modify this function to return the last but one element of the given list.
let lastButOne lst =
  failwith "Implement"

printfn "last element: %d" <| last [ 1; 2; 3; 4; 5 ]
printfn "last element: %s" <| last [ "a"; "bcd"; "efg" ]
printfn "last but one element: %d" <| lastButOne [ 1; 2; 3; 4; 5 ]
printfn "last but one element: %f" <| lastButOne [ 1.1; 2.2 ]
