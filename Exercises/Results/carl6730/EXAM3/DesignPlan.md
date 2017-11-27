## **Social Network Design Plan – Teresa Carlson**

Architecture

\* Computer client - Web browser

\* Web server - http, urls to web pages

\* Email server - SMTP

\* Application server - function interface

\* Database - CRUD for User, Post

Web Server Interface

\* Login

       \* register (fist name, last name, username, password)

       \* login (username, password)

\* Post

       \* add\_post (user, text, timestamp)

       \* edit\_post (user, text, timestamp)

       \* delete\_post (user, text, timestamp)

\* User functions

       \* add friend

       \* remove friend

       \* add blog topic

Application Server Interface

\* User

       \* CRUD - create, read, update, delete

\* Post

       \* CRUD - create, read, update, delete

Database Schema

\* User

       \* first name, last name, username, password, friendList

\* Post

       \* user, topicList,

Interfaces - Detailed Design

Social Network Web Server Interface

- Login
 - register (first name, last name, username, password)
 - login (username, password)
- Post
 - Add post (username, topic, text)
 - Add topic(username, topic to add)
 - Delete topic (username, topic to remove)
- System
 - Clear data(all MongoDB collections)
 - Import data (from JSON file)
 - Export data (to JSON file)

Social Network Server Interface (Functions)

- User
 - newUser (firstName, lastName, userName, password)
 - displayUsers ()
 - userLogin (username, password)
 - addFriend (username1, username2)
 - removeFriendship(username1, username2)
 - returnFriends(username)
- Post
 - listTopics (username)
 - addTopic (username, topic)list\_post (timestamp)
 - function newPost (username)
 - removeTopic (username, topic)
- System
 - resetData()
 - importJSON (done in command line)
 - exportJSON (done in command line)

Social Network Data

- User
 - First name, last name, username, password, friends list
- Post
 - user, topic list

Social Network Classes

- User
 - First name, last name, username, password, friends list
- Post
 - user, topic list
