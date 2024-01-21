/// KAIST CS220 In-Class Activity Project

type RationalNumber = float * float

let numer (n: RationalNumber) = fst n

let denom (n: RationalNumber) = snd n

/// Fix this function so that the rational numbers are comparable.
let makeRat n d = (n, d)

let r0 = makeRat 1 (-2)
let r1 = makeRat (-1) 2
r0 = r1
|> printfn "Is r0 and r1 the same? => %b"
