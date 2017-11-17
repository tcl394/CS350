# Pushing Code Exercise

## Goal

Learn how to get code from a remote repo and share your code with others.


## Steps

### Sign into your Personal Github Account

You signed up for a free account at Github.com.  This will be useful to you after you
are done with this class.

Sign in and go to the Code Repository named "Software-Engineering".  This repository will 
be used as your private record of your work in this class.

Do no login as UNC-CS350.

Find "Clone or Download" and choose "Use HTTPS".  Copy the link to the clipboard.

Open a console window with "Git CMD"

### Git Commands

    C:\Users\xyz>

    C:\Users\xyz> cd CS350

    C:\Users\xyz\350> git clone **PASTE your Repo Here**

    C:\Users\xyz\350> cd Software-Engineering

    C:\Users\xyz\350\Software-Engineering> dir /S

    C:\Users\xyz\350\Software-Engineering> git status

    C:\Users\xyz\350\Software-Engineering> echo 'This is my CS350 Repo' > welcome

    C:\Users\xyz\350\Software-Engineering> git status

    C:\Users\xyz\350\Software-Engineering> git add .

    C:\Users\xyz\350\Software-Engineering> git status

    C:\Users\xyz\350\Software-Engineering> git commit -m "Welcome"

    C:\Users\xyz\350\Software-Engineering> git status

    C:\Users\xyz\350\Software-Engineering> git pull

    C:\Users\xyz\350\Software-Engineering> git push

Note:  There are now two Github accounts that you are using.  The push must happen from the account that is currently logged in to Github.  If git push fails then install and use Github Desktop instead of the "git bash" console.


### Confirm Changes

You are still logged into your personal github account.

Go to the "Code" tab of the "Software-Engineering" repo.

Click on 'commits' link in the repo.  See the Welcome commit that you just pushed.


### Complete the Assignment

Login to the Github Account for UNC-CS350.

Go to the CS350 repo.

Create a file in the "Exercises/Results/yourid" folder named "PUSH_DONE".

When I see this file you will get credit for the exercise.

