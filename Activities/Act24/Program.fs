/// KAIST CS220 In-Class Activity Project

module CS220.Program

/// FIXME
let calculateTotal (customer: Customer) (spend: int) =
  assert (spend > 0)
  spend

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  let alice = { Id = "Alice"; IsRegistered = true }
  calculateTotal alice 10000
  |> printfn "Alice should pay %d KRW in total"
  calculateTotal alice 200000
  |> printfn "Alice should pay %d KRW in total"
  0 (* Never modify this *)
