
Brittany Archibeque

Design Plan

October 23, 2018

**Social Media Web Application  **

Architecture

\*Web Browser
\*Web Server

\*Email Server

**Web Server Interface**

\*Login

 Register (name, username, email, password)

 Login (username, password)

\*User

 Add posts (Status, pictures)

 Edit posts (Status)

 Delete posts (Status, pictures)

 See news feed

\*News Feed

 Follow

 Unfollow

**Application Server Interface**

\*User

 create, read, update, delete

\*Follower

 create, read, update, delete



**Social Media Web**

\*User

 Create\_user (name, username, email, password)

 Read\_user (username, password)

 Delete\_user(user\_id)

\*NewsFeed

 Create\_post (status)

 Read\_post (status)

 Update\_post (status)

 Delete\_post (status)

 Edit\_post (status)

**Data**

Social Media

\*User

 Name, username, email, password

\*Post

 User, Status, Picture

\*Follower

 User

**Classes**

\*User

 Name, username, email, password

\*Post

 User, Status, Picture

\*Follower

 User

**Functions for Data**

**\*Posts**

Def create\_post (user\_name, caption, body)

 Post.object.create (user\_name, caption, body)

Def list\_post( user\_name)

 Return post.objects.all()

Def delete\_post (user\_name, caption)

 Posts.objects.delete(user\_name=user\_name, caption=caption
