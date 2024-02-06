/// KAIST CS220 In-Class Activity Project

module CS220.Program

type BankMessage =
  | Withdraw of int
  | GetBalance of AsyncReplyChannel<int>

let account initialBalance =
  MailboxProcessor.Start (fun inbox ->
    let rec loop balance = async {
      let! msg = inbox.Receive ()
      match msg with
      | Withdraw amount ->
        if amount <= balance then
          let balance' = balance - amount
          return! loop balance'
        else
          return! loop balance
      | GetBalance ch ->
        // Hint: use the `Reply` method of AsyncReplyChannel
        failwith "Implement"
    }
    loop initialBalance
  )

// Hint: use the `PostAndReply` method of MailboxProcessor.
let currentBalance (account: MailboxProcessor<BankMessage>) =
  failwith "Implement"

let withDraw (account: MailboxProcessor<BankMessage>) amount =
  failwith "Implement"

let test (account: MailboxProcessor<BankMessage>) =
  [ withDraw account 1000
    withDraw account 1500 ]
  |> Async.Parallel
  |> Async.Ignore
  |> Async.RunSynchronously

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  let acc = account 1500
  currentBalance acc
  test acc
  currentBalance acc
  0 (* Never modify this *)
