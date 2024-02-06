/// KAIST CS220 In-Class Activity Project

module CS220.Program

open FSharpx.Collections

let inf =
  LazyList.unfold (fun n -> Some (n, n + 1)) 1

// Problem
let pairwise lst =
  failwith "Implement"

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  inf
  |> pairwise
  |> LazyList.take 10
  |> LazyList.iter (fun (a, b) -> printfn "%d, %d" a b)
  0 (* Never modify this *)
