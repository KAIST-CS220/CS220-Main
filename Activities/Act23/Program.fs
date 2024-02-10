/// KAIST CS220 In-Class Activity Project

module CS220.Program

open System

type Input = { ID: string; PW: string }

let validateID input =
  if input.ID.Length > 4 && input.ID.Length <= 12 then Ok input
  else Error "Invalid ID length."

let validatePWLength input =
  if input.PW.Length > 8 then Ok input
  else Error "Invalid password length."

let validatePWLowercase input =
  if input.PW |> String.exists Char.IsLower then Ok input
  else Error "PW should include a lowercase letter."

let validatePWUppercase input =
  if input.PW |> String.exists Char.IsUpper then Ok input
  else Error "PW should include an uppercase letter."

let validatePWDigit input =
  if input.PW |> String.exists Char.IsDigit then Ok input
  else Error "PW should include a digit."

let trimID input =
  { input with ID = input.ID.Trim () }

let trimPW input =
  { input with PW = input.PW.Trim () }

let validate input =
  failwith "Implement"

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  validate { ID = "alice"; PW = "  iloveyou  " }
  |> printfn "%A"
  validate { ID = "bob"; PW = "  iloveYou42  " }
  |> printfn "%A"
  validate { ID = "charlie42"; PW = "IloveYou42" }
  |> printfn "%A"
  0 (* Never modify this *)
