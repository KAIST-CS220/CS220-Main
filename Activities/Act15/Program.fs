/// KAIST CS220 In-Class Activity Project

module CS220.Program

/// Fix this.
let length _ = failwith "Implement"

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  [| 4; 2 |] |> length |> printfn "%d"
  [ 4; 2 ] |> length |> printfn "%d"
  "abcd" |> length |> printfn "%d"
  0 (* Never modify this *)
