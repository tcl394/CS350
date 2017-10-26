# Facebook Lite Design Plan

### Architecture

* Computer client - Web browser (Chrome, Edge, Firefox etc...)
* Mobile Client
* Web server - http,https, urls to web pages
* Application server
* Database - CRUD for User and Post

### Interfaces

Web Server Interface
* Login
  * Register(FirstName, LastName, Email, Password)
  * Login(Email, Password)
  * Logout()
* Post
  * Create(UsersName, Content)
  * Update(PostID, UsersName, Content)
  * Delete(PostID, UsersName/ID?)
* Display
  * ShowPosts()
  
Application Server
* User
 * CRUD 
* Post
 * CRUD
 
Database Schema
* Users
* Posts

### Data

Database schema

* User
  * First name
  * Last name
  * email
  * password
* Post
  * user
  * content

Classes

* User
  * firstname, lastname, email, password
* Post
  * user, contents


Functions for Data



Post

  def create_post (user_id, contents):
  
      Post.object.create (user_id, contents)

  def list_post (user_id):
  
      return Post.objects.all()

  def read_post (article_id):
  
      return Post.objects.get(pk=article_id)

  def update_post (user_id, contents, update):
  
      a = Post.objects.get (user_id=user_id, contents=contents)
      a.contents = update
      a.save()

  def delete_post (user_id, title):
  
      Post.objects.delete(user_id=user_id, title=title)


User

  def create_user(FirstName, LastName, Email, Password):
  
      User.object.create (FirstName, LastName, Email, Password)

  def list_users (user_id):
  
      return User.objects.all()

  def read_user (user_id):
  
      return User.objects.get(pk=Post.objects.get(user_id))

  def update_user (user_id, contents, update):
  
      a = Post.objects.get (user_id=user_id, contents=contents)
      
      a.contents = update
      
      a.save()

  def delete_User (user_id):
  
      User.objects.delete(user_id=user_id)

