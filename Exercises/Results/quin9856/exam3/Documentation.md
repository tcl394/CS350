# Note:
  When the program is initally run there are no created users. You must create one before you login. Once users have been created you can export them (see system documentation below), and then you will have the ability to import these users along with their previous friends and posts, next time you start the program (see system documentation).

## PERSON
- A user can register to use the system: 
      Run the test file
      Enter 1 for create a new user
      Enter desired username and password
    With the inputted information, a user will be created as a 'Person' object and appened to the userList found in the test file
    
- After login the user ID is used for all other calls
    Exmaples of this include the situation in which a user adds a friend by inserting the friends username

## FRIEND
- A list of friends is returned for a user
      Run test file
      Log in to created account
      Type 4 to view current list of friends
    The 'Person' object has a friends list which is called in the printFriends method within the class.
    
- A new friendship is formed between two users
      Run test file
      Log in
      Type 5 to add a friend 
      Insert username of another user within the system
    When the user adds a friend by username, the friend automattically becomes friends with the user.
    There is an add friend method within the Person class which is called in the test file
    
- Remove a friendship
      Run test file
      Log in
      Type 6 to remove friend
      Type username of friend you wish to remove
    The friend will be removed from your friends list, as well as you removed from theirs
    There is a remove friend method within the Person class
    
## POST
- List topics for a user
      Run test file
      Log in
      Type 1 to view posts of the logged in user's friends, or 2 to view the logged in users posts
    There is a post class with a constructor that is simply a list of posts. Each person object has its own individual post object and as a result each person has thier own list of posts.
      
      
- Add topic for a user from a friend (interpretted as make a new post)
      Run test file
      log in
      Type 3 to make a new post
      Enter the text which you want your post to say
    Your post will be saved/appended to your personal posts list 
      
- Remove a topic
      Run test file
      Log in
      Type 2 to manage your post options
      Type 2 to remove a post
      Each post will have a number in front of it, enter the number of the post you want to delete
    This will remove the post from the logged in users posts list
    
# SYSTEM
- Reset all data
      Run test file
      Log in
      Type 3 for System Options
      Type 1 to reset data
    This will erase all users as well as their friends and posts
    
- Export
      Run test file
      Log in
      Type 3 for system options
      Type 2 to export
    To export objects I am using a library called pickle
    This will save all the users to a file called users.pickle as well as the friends and posts that those users have made
    
- Import
    Run test file
    Log in
    Type 3 for system options
    Type 3 to import
   This will load in all users, friends, and posts that were last exported to the users.pickle file
