/// KAIST CS220 In-Class Activity Project

namespace CS220

type ParserBuilder () =
  member _.Bind (p, f) =
    { Parse = (fun s ->
        match Parser.runOnInput p s with
        | Ok (v, rest) -> Parser.runOnInput (f v) rest
        | Error e -> Error e) }

  member _.Return (v) =
    { Parse = fun s -> Ok (v, s) }

