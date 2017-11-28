**Design plan**.

Person

The new user can register to become user of this social media. And after registering the user can login as user.

- Register
- Login

Friend

Users after became user they have option to create friendship with other users. And they can send friend request, list all his/her friends, if they have friend request they can confirm the request, and they have an option to remove the friendship.

- List\_of \_ friend
- Send\_ friend\_ request
- Confirm\_Friendship\_request
- Remove\_Friend\_request
- Notefication

Post

Users after registered and became user and logged in as user then they have an option to post article, list all topics, and remove the topics.

- Add\_ topics
- List\_topics
- Remove\_ topics

System

May be the system admin logged ad admin and  can reset all data, import and export the data.

- Reset\_\_all\_data
- Import\_data
- Export\_data







Architecture

- Application server:  function interface
- Database: CRUD for User, Post, Friend

Interface

- Person

- Register (first\_name, last\_name, email, password)
- Login (email, password)

- Friend

- List\_of \_ friend (useremail)
- Send\_ friend\_ request (user\_email)
- Confirm\_Friendship\_request (User\_email, Friends\_email)
- Remove\_Friend\_request (email\_to\_be\_remoed)
- Notefication(email)
-

- Post

- Add\_ topics (user, topic, body)
- List\_topics (user, topic, body)
- Remove\_ topics (topic)

- System

- Reset\_table (table\_name)
- Import\_data ()
- Export\_data ()

Application Server Interface

- Person

- CRUS - Create, Read, Edit, Delete

-  Friend

- CRUS - Create, Read, Edit, Delete

- Post

- CRUS - Create, Read, Edit, Delete

- System

- CRUS - Create, Read, Delete

Database Schema

- Person

- Fname, lname, email, password

- Post

- User, topic, body

- Friend

- User, Friend\_fname, friend\_lname, friend\_email

- System

- Table\_name





Social Media Server Interface (Function)

- Person

- Register\_user (First\_name, last\_name, email, password)
- Log\_in (email, password)

- Post

- Create\_post (user\_id, topic, body)
- List \_post(topic)
- Remove\_post (topic)

- Friend

- Send\_friend\_request (user, name)
- Confirm\_Friendship\_request (user, name)
- Remove\_friend(user)
- List\_of \_ friend (useremail)
- Notefication(email)

- System

- Reset\_table(tablename)
- Inport\_data ()
- Exporte\_data()

Data

Object Relational Mapping (Rom)

Social media data

- Person

- First\_name, last\_name, email, password

- Post

- User, topic, body

- Friend

- User, friend,

Social media classes

- Person

- First\_name, last\_name, email, password

- Post

- User, topic, body

- Friend

- User, friend

- System

- Table\_name



Social media function for data

- Person

public Boolean Registration (First\_name, last\_name, email, password)

Person person = new Person ()

person. Registration (First\_name, last\_name, email, password)

public Boolean Login(string email, string password)

Person person = new Person ()

 person..login (email, password)

- Post

        public Boolean Add\_topics(string email)

         Post post = new Post()

         post.Add\_topics(email)

        public Boolean List\_topics()

        Post post = new Post()

         post.List\_topics()

          public Boolean Remove\_topics()

                Post post = new Post()

                 post.Remove\_topics()

- Friend

public Boolean Send\_Friend\_request(string user\_email)

       Friend friend = new Friend()

       friend.Send\_Friend\_request(string user\_email)

          public Boolean Remove\_Friendship()

          Friend friend = new Friend()

          friend.Remove\_Friendship()

          public Boolean List\_Friends(string useremail)

                         Friend friend = new Friend()

          friend.List\_Friends(string useremail)

    public Boolean Confirm\_Friendship\_request(string User\_email, string Friends\_email)

       Friend friend = new Friend()

       friend.Confirm\_Friendship\_request(string User\_email, string Friends\_email)

     public string  Notefication(string email)

              Friend friend = new Friend()

       friend.Notefication(string email)

   public Boolean Remove\_Friend\_request(string email\_to\_be\_removed)

               Friend friend = new Friend()

       friend.Remove\_Friend\_request(string email\_to\_be\_removed)

- System

Public boolean Reset\_data(tablename)

System system= new System()

system. Reset\_data(tablename)

Public boolean Export(tablename)

System system= new System()

system. Export(tablename)

Public boolean Import(tablename)

System system= new System()

system. Import(tablename)