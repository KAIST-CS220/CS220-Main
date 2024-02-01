/// KAIST CS220 In-Class Activity Project

namespace CS220

open System
open System.IO
open System.Text.RegularExpressions

type DB = User list

module DB =
  let (|DBLine|_|) line =
    let m = Regex.Match (line, "([^,]+),(.+)")
    if m.Success then
      Some (m.Groups[1].Value.Trim (), m.Groups[2].Value.Trim ())
    else None

  let initializeFromCSV path =
    File.ReadAllLines path
    |> Array.choose (fun line ->
      match line with
      | DBLine (name, pw) -> failwith "Implement"
      | _ -> None)
    |> Array.toList
