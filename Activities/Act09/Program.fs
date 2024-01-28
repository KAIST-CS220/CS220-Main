/// KAIST CS220 In-Class Activity Project

open System.Diagnostics

type Hero =
  | SuperMan
  | BatMan
  | SpiderMan

let heroes = [ SuperMan; BatMan; SpiderMan ]

/// Modify this to be tail-recursive.
let rec map f = function
  | [] -> []
  | hd :: tl -> f hd :: map f tl

let isWearingMask hero = failwith "Implement"

let shirtColor hero = failwith "Implement"

map isWearingMask heroes |> printfn "%A"

let many =
  List.init 100000 (fun idx ->
    match idx % 3 with
    | 0 -> SuperMan
    | 1 -> BatMan
    | _ -> SpiderMan)

map isWearingMask many |> printfn "%A"
