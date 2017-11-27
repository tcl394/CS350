
# Design, Code, and Test the following data models

## Person
    -A user can register to use the system
    -After login the user ID is used for all other calls
## Friend
    -A list of friends is returned for a user
    -A new friendship is formed between two users
    -Remove a friendship
## Post
    -List topics for a user
    -Add topic for a user from a friend
    -Remove a topic
## System
    -Reset all data
    -Export 
    -Import

## Testing is using as real time
        -I did not use one test for all unit because I am pretty new with python. I want to learn and understand more about python so that this is why I choose to design this assignment as testing in real time, user has to input information to execute the program with                different options.
        -Beginning with login into the system with username: user1, password: password1 (intent that the person.csv file exists at beginning)
        -Or register as a new user to access following options, then you can login with that account
        -UserID, postID are not auto random generated yet, we have to manually enter them.
        -List of friends will provide the userID in this program
        -Add a friend into a list of user is written into friend.csv file, which is the first element will be the user, following elements are friend - userID
        -Reset all data will truncate all data in friend.csv,post.csv,and person.csv file
        -Export will create friend.txt,post.txt,and person.txt with current datas on .csv files
        -Import will import all data from friendImport.txt, postImport.txt, personImport.txt into .csv files, note that all the data in .csv files will be gone.
    
