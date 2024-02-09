/// KAIST CS220 In-Class Activity Project

module CS220.Program

open CS220.ParsingOps

let digit =
      char '0'
  <|> char '1'
  <|> char '2'
  <|> char '3'
  <|> char '4'
  <|> char '5'
  <|> char '6'
  <|> char '7'
  <|> char '8'
  <|> char '9'

let number =
  parser {
    let! d = digit
    let! ds = many digit
    return List.toArray (d :: ds) |> System.String |> int |> Number
  }

let mutable exprRef = { Parse = fun _ -> failwith "X" }

let expr = { Parse = fun s -> Parser.runOnInput exprRef s }

let arith op lhs rhs constructor =
  parser {
    let! n = lhs
    let! _ = many (char ' ')
    let! _ = char op
    let! _ = many (char ' ')
    let! e = rhs
    return constructor (n, e)
  }

let muldiv = parser {
  failwith "Implement"
  return (Number 0)
}

let term = parser {
  let! n = number
  let! _ = many (char ' ')
  let! r = muldiv
  return r
}

let add = arith '+' term expr Add
let sub = arith '-' term expr Sub
exprRef <- add <|> sub <|> term

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  Parser.runOnInput expr "1 + 2 * 3 / 4 - 5"
  |> printfn "%A"
  0 (* Never modify this *)
