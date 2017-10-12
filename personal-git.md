# Personal Git Exercise

## Goal

Learn how to work with a git repo to do version control while disconnected from the internet.

![Git Mental Model](Git.png)

## Commands

init - create a new archive
add - add changes to the staging index
status - show changes in source code
commit - move all changes from staging to repo
checkout - move a specific version of code into the working directory


## Practice

    C:\Users\xyz>

    C:\Users\xyz> mkdir CS350

    C:\Users\xyz> cd CS350

    C:\Users\xyz\350> git init

    C:\Users\xyz\350> dir /S

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> echo 'My Repo Lives Here' > xyz

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> git add .

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> git commit -m "First Commit"

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> git log

    C:\Users\xyz\350> echo 'ABC' > abc

    C:\Users\xyz\350> del xyz

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> git add -A .

    C:\Users\xyz\350> git commit -m "Test out deleting files"

    C:\Users\xyz\350> git status

    C:\Users\xyz\350> git log

