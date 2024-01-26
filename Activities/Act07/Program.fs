/// KAIST CS220 In-Class Activity Project

/// Problem 1: this is currently an integer list. Modify this type to be a
/// generic list type.
type MyList =
  | Nil
  | Cons of int * MyList

let empty =
  Nil

let cons elt lst =
  Cons (elt, lst)

let car lst =
  failwith "Implement"

let cdr lst =
  failwith "Implement"

let (^+^) = cons

let intList = 1 ^+^ 2 ^+^ 3 ^+^ empty
// let stringList = "a" ^+^ "B" ^+^ "c" ^+^ empty

printfn "%A" <| intList
printfn "%d" <| car intList
printfn "%A" <| cdr intList
// printfn "%A" <| stringList
// printfn "%A" <| car stringList
// printfn "%A" <| cdr stringList

/// Problem 2: this function returns the length of the given list.
let length lst =
  failwith "Implement"

// printfn "%d" <| length lst

/// Problem 3: this function checks if the given element is included in the
/// given list.
let isMember elm lst =
  failwith "Implement"

// printfn "is X a member? %b" <| isMember "X" stringList
// printfn "is B a member? %b" <| isMember "B" stringList

/// Problem 4: this function joins two lists.
let append lst1 lst2 =
  failwith "Implement"

let lst1 = 1 ^+^ 2 ^+^ empty
let lst2 = 3 ^+^ 4 ^+^ empty
// printfn "%A" <| append lst1 lst2

/// Problem 5: this function returns a reversed list.
let rev lst =
  failwith "Implement"

// printfn "%A" <| rev lst1
