## Social Retirement System

Architecture


	* Computer client - Web browser
	* Web server - https, urls to web pages
	* Application server - function interface
	* Database - User information, post information


Web Server Interface


	* Login

		* register (name, email, password)
		* login (name, password)
	* Feed
	
        * post (post content, comments)


Application Server Interface


	* User

		* CRUD - create, read, update, delete
	* Post

		* CRUD - create, read, update, delete


Database Schema


	* User

		* name, email, password, settings, extra info
	* Post
	
        * OP, content, comments



Interfaces - Detailed Design

Start with Architecture (High-level Design)

	* Subsystems - partitioning of components
	* Interfaces - every subsystems has at least one interface
	* Data and control flow - walk the call chain


Social Retirement Web Server Interface 


* Login

	* register (name, email, password)
	* login (name, password)
* Post

	* add_post (user, content, date)
* Feed

	* get_posts (OP, content)
	* list_posts (user)
	* add_comment (user, content, date)

Social Retirement Application Server Interface (Functions)


* User

	* create_user (name, email, password)
	* read_user (name, password) --> user_id
	* list_user () --> user list
	* update_user (name, email, password)
	* delete_user (user_id)



* Post

	* create_post (user_id, content, date)
	* get_post (post_id)
	* list_post (user_id)
	* update_post (user_id, content, date)
	* delete_post (user_id)



Data

ORM


	* Define your database structures by specifying classes.  
	* Automatically generate SQL to match the objects.
	* All work is done in the object domain.


Social Retirement Data


* User

	* name, email, password, extra info
* Post

	* user, content, date


Social Retirement Classes


* User

	* name, email, password, extra info
* Post

	* user, content, date


Social Retirement Functions for Data

	  # Post

	  def create_post (user_id, content, date):
	      Post.object.create (user_id, content, date)

	  def list_post (user_id):
	      return Post.objects.all()

	  def get_post (post_id):
	      return Post.objects.get(pk=post_id)

	  def update_post (user_id, content, date):
	      a = Post.objects.get (user_id=user_id, title=title)
	      a.content = content
	      a.date = date
	      a.save()

	  def delete_post (user_id, post_id):
	      Post.objects.delete(user_id=user_id, post_id=post_id)
