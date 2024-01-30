/// KAIST CS220 In-Class Activity Project

module CS220.Program

/// Fix this function to make `list1` and `list2` the same.
let convert lst =
  []

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  let list1 = List.init 1000 id
  let list2 =
    List.init 1000 (fun i -> if i % 2 = 0 then EvenNumber.create i
                             else OddNumber.create i)
  list1 = convert list2 |> printfn "%b"
  0 (* Never modify this *)
