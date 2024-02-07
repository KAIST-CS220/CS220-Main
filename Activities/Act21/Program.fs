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

let add =
  parser {
    failwith "Implement"
    return Add (Number 0, Number 0)
  }

let sub =
  parser {
    failwith "Implement"
    return Sub (Number 0, Number 0)
  }

exprRef <- add <|> sub <|> number

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  Parser.runOnInput expr "1 + 42 - 555"
  |> printfn "%A"
  0 (* Never modify this *)
