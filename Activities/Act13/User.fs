/// KAIST CS220 In-Class Activity Project

namespace CS220

type User = {
  Name: string
  Password: string
}

module User =
  let toString user =
    $"{user.Name}'s password is {user.Password}"
