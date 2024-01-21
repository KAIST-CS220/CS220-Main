/// KAIST CS220 In-Class Activity Project

type Shape =
  /// A circle of a radius.
  | Circle of float
  /// A square with a side length.
  | Square of float
  /// A triangle with side lengths.
  | Triangle of float * float * float

let area shape =
  0.0

let circle = Circle 0.5
let square = Square 1.0
let triangle = Triangle (1.0, 1.0, 1.0)

printfn "circle = %f" <| area circle
printfn "square = %f" <| area square
printfn "triangle = %f" <| area triangle
