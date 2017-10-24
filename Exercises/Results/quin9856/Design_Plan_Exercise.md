#
# Design Plan:

## **Architecture:**

- Computer client - Web browser
- Web server - http, urls to web pages
- Application server - function interface
- Database - CRUD for User, Status, Friends

## **Interface:**

### **Web Server Interface:**

- Login
  - register (name, email, password)
  - login (name, password) \*User
- Manage Friends
  - add\_friend (user)
  - remove friend (user)
- Posts
  - add\_post (user, post)
  - edit\_post (user, post)
  - delete\_post (user, post)
  - comment\_post(user, post, comment)

### **Web Server Interface (Functions)**

- User
  - create\_user (name, email, password)
  - read\_user (name, password) --&gt; user\_id
  - list\_user () --&gt; user list
  - update\_user (name, email, password)
  - delete\_user (user\_id)
- Posts
  - create\_post (post\_id, post)
  - read\_post (post\_id)
  - update\_post (user\_id, post)
  - delete\_post (user\_id)
  - make\_comment(post\_id, user\_id, comment)

### **Application Server Interface:**

- User
  - CRUD - create, read, update, delete
- Post
  - CRUD - create, read, update, delete
- Friend
  - CRUD - create, read, update, delete
- Follower
  - CRUD - create, read, update, delete

### **Database Schema**

- User
  - name, email, password
- Post
  - user, body, likes \*Comment
  - post, comment
- Friend
  - User
- Follower

## **Data:**

### **Facebook**  **Data**

- User
  - name, email, password
  - User, post, comments
- Post
  - User, title, body
- Friend
  - User, user
- Follower
  - User, Account

### **Facebook Classes**

- User
  - name, email, password
- Post
  - User, post, comments
- Friend
  - User, User
- Follower
  - User, account
