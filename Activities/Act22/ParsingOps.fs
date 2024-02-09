/// KAIST CS220 In-Class Activity Project

namespace CS220

open System

module ParsingOps =
  let parser = ParserBuilder ()

  let char ch =
    { Parse = fun s ->
        if String.IsNullOrEmpty s then
          Error "No more input."
        elif s[0] = ch then Ok (s[0], s[1..])
        else Error "Invalid character." }

  let andThen p1 p2 =
    parser {
      let! a = p1
      let! b = p2
      return (a, b)
    }

  let (.>>.) = andThen

  let rec sequence = function
    | [] -> parser { return [] }
    | hd :: tl ->
      parser {
        let! h = hd
        let! t = sequence tl
        return (h :: t)
      }

  let map f parser =
    { Parse = fun s ->
        match Parser.runOnInput parser s with
        | Ok (v, rest) -> Ok (f v, rest)
        | Error e -> Error e }

  let (|>>) p f = map f p

  let orElse p1 p2 =
    { Parse = fun s ->
        match Parser.runOnInput p1 s with
        | Ok (v, rest) -> Ok (v, rest)
        | Error _ -> Parser.runOnInput p2 s }

  let (<|>) = orElse

  let rec zeroOrMore p s =
    match Parser.runOnInput p s with
    | Ok (v, s) ->
      let v', s' = zeroOrMore p s
      v :: v', s'
    | Error _ -> ([], s)

  let many p =
    { Parse = fun s -> Ok (zeroOrMore p s) }
