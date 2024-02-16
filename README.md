KAIST CS220
===

Welcome to the `main` repository of CS220. This is where you find your H/W resources and ask questions.

# FAQs

## Shell

Shell is a program that allows you to interact with your computer using text
commands. You'd better get used to it to do your homeworks. There are many
different kinds of shells, but here are some of the most popular ones for each
platform.
- Windows: [Windows Terminal](https://learn.microsoft.com/en-us/windows/terminal/install) (recommended) or PowerShell.
- macOS: [Terminal](https://support.apple.com/guide/terminal/welcome/mac)
- Linux: bash, zsh, etc.

We will assume that you understand how to list files/directories, modify
files/directories, and launch programs using a shell. You may find
[this](https://missing.csail.mit.edu/) useful.

## Git

### How do I clone this repository?

There are roughly three ways. You should install
[Git](https://git-scm.com/downloads) first, and optionally install [GitHub
CLI](https://cli.github.com/) for the third method.

1. Using HTTPS

    ```bash
    git clone https://github.com/KAIST-CS220/CS220-Main.git
    ```

2. Using SSH

    To learn how to connect GitHub with SSH, see [this
    guide](https://docs.github.com/en/authentication/connecting-to-github-with-ssh).


    ```bash
    git clone git@github.com:KAIST-CS220/CS220-Main.git
    ```

3. Using GitHub CLI

    ```bash
    gh repo clone KAIST-CS220/CS220-Main
    ```

### How do I use Git?

You should learn basic commands to do your homeworks. In most cases, your
workflow will be as follows.

1. You clone a repository to your local machine using one of the commands above,
   i.e., `git clone ...`, etc.
2. You now modify some of the files in your local (cloned) repository.
3. You want to save your changes by first adding modified files to the staging
   area with `git add <file>` command. The command will mark the file to be
   included in the next commit you make.
4. You then commit the changes in the staging area with `git commit -m "commit
   message"` command. The `-m` option is for specifying the commit message.
5. Finally, you push the commit to the remote repository with `git push`
   command.
6. Always remember to make sure that your push is successful by checking the
   GitHub web page.

### How do I install .NET SDK?

You should install .NET SDK 8.0 or above. Please read this
[guide](https://learn.microsoft.com/en-us/dotnet/core/install/).
