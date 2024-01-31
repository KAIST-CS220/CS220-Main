/// KAIST CS220 In-Class Activity Project

module CS220.Program

/// Fix this function to make an imperative counter.
let counter () =
  42

/// Fix this function to create a counter function.
let createCounter () =
  fun () -> 42

type CounterState = {
  Count: int
}

let createPureCounter () =
  fun st -> { st with Count = st.Count + 1 }

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  (* mutable counter *)
  let x = createCounter ()
  let y = createCounter ()
  let z = y
  x () |> printfn "x: %d"
  y () |> printfn "y: %d"
  z () |> printfn "z: %d"
  x () |> printfn "x: %d"
  y () |> printfn "y: %d"
  z () |> printfn "z: %d"
  y () |> printfn "y: %d"
  (* immutable counter *)
  let x = createPureCounter ()
  let y = createPureCounter ()
  let stateX = { Count = 1 }
  let stateY = { Count = 1 }
  let stateZ = stateY
  printfn $"x: {stateX.Count}"
  printfn $"y: {stateY.Count}"
  printfn $"z: {stateZ.Count}"
  let stateX = x stateX
  let stateY = y stateY
  printfn $"x: {stateX.Count}"
  printfn $"y: {stateY.Count}"
  printfn $"z: {stateZ.Count}"
  0 (* Never modify this *)
