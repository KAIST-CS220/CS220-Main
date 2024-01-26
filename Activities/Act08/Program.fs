/// KAIST CS220 In-Class Activity Project

open System.Diagnostics

let length lst =
  let rec loop cnt = function
    | [] -> cnt
    | _ :: tl -> loop (cnt + 1) tl
  loop 0 lst

let bigList = List.init 10000 id
let myList = List.init 10000 (fun idx -> if idx % 2 = 0 then [] else bigList)

/// Problem 1: Count empty lists in the given list of list.
let countEmptyList lst =
  0

let stopWatch = Stopwatch ()
stopWatch.Start ()
printfn "%d" <| countEmptyList myList
stopWatch.Stop ()
printfn $"Elapsed time: {stopWatch.Elapsed.ToString ()}"

/// Problem 2: Check whether the two given lists are equivalent.
let equal lst1 lst2 =
  true

let lstA = [ 1; 2; 3; 4 ]
let lstB = [ 4; 3; 2; 1 ]
printfn "A = B? %b" <| equal lstA lstB
