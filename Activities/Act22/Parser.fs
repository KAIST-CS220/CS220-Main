/// KAIST CS220 In-Class Activity Project

namespace CS220

type Parser<'T> = {
  Parse: string -> Result<'T * string, string>
}

module Parser =
  let runOnInput parser str =
    parser.Parse str

