# Design Plan
### Social Network Site

## Architecture


* Computer client - Web browser
* Web server - http, urls to web pages
* Email server - SMTP
* Application server - function interface
* Database - CRUD for User, Post, Friend


Web Server Interface


* Login

	* register (name, email, password)
	* login (name, password)
* Author

	* add_post (user, body, post_id)
	* edit_post (user, body, post_id)
	* delete_post (user, post_id)
* Friend

	* get_post (post_id)
	* list_posts (user)
* News

	* register (email)
	* verify_email (token)
	* unsubscribe (email)


Application Server Interface


* User

	* CRUD - create, read, update, delete
* Post

	* CRUD - create, read, update, delete
* Friend

	* CRUD - create, read, update, delete


Database Schema


* User

	* name, email, password
* Post

	* user, post_id, body
* Friend

	* user_id



## Interfaces

Social Network Interface


* User

	* create_user (name, email, password)
	* read_user (name, password) --> user
	* list_user () --> user list
	* update_user (name, email, password)
	* delete_user (user)



* Post

	* create_post (user, post_id, body)
	* read_post (post_id)
	* list_post (user)
	* update_post (user, post_id, body)
	* delete_post (post_id)



## Data

Social Network Data


* User

	* name, email, password
* Post

	* user, post_id, body
* Friend

	* user


Social Network Classes


* User

	* name, email, password
* Post

	* user, post_id, body
* Friend

	* user


Social Network Functions for Data

	  # Post

	  def create_post (user, post_id, body):
	      Post.object.create (user, post_id, body)

	  def list_post (user):
	      return Post.objects.all()

	  def read_post (post_id):
	      return Post.objects.get(pk=post_id)

	  def update_post (user, post_id, body):
	      a = Post.objects.get (user=user, post_id=post_id)
	      a.body = body
	      a.save()

	  def delete_post (user, post_id):
	      Post.objects.delete(user=user, post_id=post_id)
