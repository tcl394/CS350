

# Design Plan

**Architecture**

Web Browser, Client Side

Web Server / Https

Database - txt files

**Web Server Interface**

- Person

 register(name, email, password)

 login(email, password)

- Friend

 add\_friend(email)

 remove\_friend(email)

 show\_friends(user)

- Post

 post\_add(user\_ID, post)

 post\_delete(user\_ID, post\_ID)

 post\_comment(user\_ID, post\_ID, comment)

 show\_post\_comments(user\_ID, post\_ID, comment\_ID)

- System

 sys\_reset()

 sys\_export(path)

 sys\_import(path)

**Functions**

- Person

 public class user:

 str Name;

 str email;

 int userID;

 str pass;

 getters and setters

 create\_user(name,email,password)

  creates a new user

 validate\_user(email, password)

  used for sign in

 add\_friend(email)

  adds a pairing to the friends.txt file

 remove\_friend(email)

  removes a pairing from the friends.txt file

 show\_friends(userID)

  lists all a users friends

- **Post**

 public class post:

 str content;

 str userID;

 str postID;

 getters and setters

 show\_posts(userID)

  lists all posts by user

 create\_post(userID, post)

  content = post

  total\_posts =+ 1

  postID = total\_posts

  creates a post for a user and adds it to the posts.txt file

 remove\_post(userID, post\_ID)

  removes a post from the posts.txt file

**System**

sys\_reset()

 finds all .txt files and deletes them

sys\_export(path)

 exports all .txt files to the specified folder

sys\_import(path))

 imports all .txt files from a specified folder, should check for names friends.txt, users.txt, posts.txt


	
