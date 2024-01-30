/// KAIST CS220 In-Class Activity Project

type Hero =
  | SuperMan
  | BatMan
  | SpiderMan

let heroes = [ SuperMan; BatMan; SpiderMan ]

let sumOfCapes acc hero =
  failwith "Implement"

let rec fold f acc = function
  | [] -> acc
  | hd :: tl -> fold f (f acc hd) tl

/// Problem 1
let foldBack f lst acc =
  failwith "Implement"

fold sumOfCapes 0 heroes |> printfn "%d"

let many =
  List.init 10000 (fun idx ->
    match idx % 3 with
    | 0 -> SuperMan
    | 1 -> BatMan
    | _ -> SpiderMan)

fold sumOfCapes 0 many |> printfn "%d"
foldBack sumOfCapes many 0 |> printfn "%d"

/// Problem 2
let reduce f lst =
  failwith "Implement"

reduce (+) [ 1; 2; 3 ] |> printfn "%d"
reduce (+) [ 3 ] |> printfn "%d"
