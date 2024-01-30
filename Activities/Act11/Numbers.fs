/// KAIST CS220 In-Class Activity Project

namespace CS220

type Number =
  | OddNumber of int
  | EvenNumber of int

module OddNumber =
  /// Raise `failwith` exception when the given number is not odd.
  let create n =
    failwith "Implement"

module EvenNumber =
  /// Raise `failwith` exception when the given number is not even.
  let create n =
    failwith "Implement"

module Number =
  /// Convert `Number` to `int`
  let toInt n =
    failwith "Implement"
