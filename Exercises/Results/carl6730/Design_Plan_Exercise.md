## **Super Basic Social Network Design Plan**  **– Teresa Carlson**

Architecture

\* Computer client - Web browser

\* Web server - http, urls to web pages

\* Email server - SMTP

\* Application server - function interface

\* Database - CRUD for User, Post

Web Server Interface

\* Login

        \* register (name, email, password)

        \* login (name, password)

\* Post

        \* add\_post (user, text, timestamp)

        \* edit\_post (user, text, timestamp)

        \* delete\_post (user, text, timestamp)

\* Newsfeed

        \* get\_post (text)

        \* list\_posts (user, timestamp)

Application Server Interface

\* User

        \* CRUD - create, read, update, delete

\* Post

        \* CRUD - create, read, update, delete

Database Schema

\* User

        \* name, email, password

\* Post

        \* user, text, timestamp

Interfaces - Detailed Design

Super Basic Social Network Web Server Interface

- Login
  - register (name, email, password)
  - login (email, password)
- Post
  - add\_post (user, text, timestamp)
  - edit\_post (user, text, timestamp)
  - delete\_post (user, text, timestamp)
- Newsfeed
  - get\_post (text)
  - list\_posts (user, timestamp)

Super Basic Social Network Server Interface (Functions)

- User
  - create\_user (name, email, password)
  - read\_user (email, password)
  - list\_user () --&gt; user list
  - update\_user (name, email, password)
  - delete\_user (email, password)
- Post
  - create\_post (user, text, timestamp)
  - read\_post (user, text, timestamp)
  - list\_post (timestamp)
  - update\_post (user, text)
  - delete\_post (user, text, timestamp)

Super Basic Social Network Data

- User
  - name, email, password
- Post
  - user, text, timestamp

Super Basic Social Network Classes

- User
  - name, email, password
- Post
  - user, text, timestamp

Super Basic Social Network Functions for Data

  # Post

  def create\_post (user, text, timestamp):

      Post.object.create (user, text, timestamp)

  def newsfeed\_all (user\_id):

      return Post.objects.all()

  def read\_post (user, text, timestamp):

      return Post.objects.get((user, text, timestamp)

  def update\_post (user, text, timestamp):

      p = Post.objects.get ((user, text, timestamp)

      p.body = body

      p.save()

  def delete\_post (user, text, timestamp):

      Post.objects.delete(user = user, text = text , timestamp = timestamp)
