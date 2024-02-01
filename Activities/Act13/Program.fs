/// KAIST CS220 In-Class Activity Project

module CS220.Program

open System
open System.IO

/// This is the main entry point.
[<EntryPoint>]
let main _ =
  let dllPath = Reflection.Assembly.GetExecutingAssembly().Location
  let dllDir = Path.Combine (Path.GetDirectoryName dllPath, "data")
  let filePath = Path.Combine (dllDir, "users.csv")
  DB.initializeFromCSV filePath
  |> List.iter (fun user -> printfn "%s" (User.toString user))
  0 (* Never modify this *)
