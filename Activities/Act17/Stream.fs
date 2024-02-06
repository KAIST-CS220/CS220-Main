/// KAIST CS220 In-Class Activity Project

namespace CS220

type Stream<'a> =
  | Nil
  | Cons of 'a * (unit -> Stream<'a>)

module Stream =
  let car stream = failwith "Implement"

  let cdr stream = failwith "Implement"

  let take n stream = failwith "Implement"

  let fromList lst = failwith "Implement"

