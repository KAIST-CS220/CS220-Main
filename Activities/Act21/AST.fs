/// KAIST CS220 In-Class Activity Project

namespace CS220

type Expr =
  | Number of int
  | Add of Expr * Expr
  | Sub of Expr * Expr

