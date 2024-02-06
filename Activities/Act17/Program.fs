/// KAIST CS220 In-Class Activity Project

module CS220.Program

open Stream

let rec ones = Cons (1, fun () -> ones)

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  [1; 2; 3; 4; 5]
  |> fromList
  |> take 3
  |> cdr
  |> cdr
  |> car
  |> printfn "%d"
  0 (* Never modify this *)
