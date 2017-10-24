# Design Plan Exercise

## Architecture

Architecture - Top-level system design

	* Interfaces
	* Building blocks


Block Diagram

	* Mobile clients
	* Computer clients
	* Web server
	* Application server
	* Database


Architecture Process

	* Partition the system
	* Define interfaces
	* Create a test plan
	* Manage dependencies


Interfaces

	* Each interface can be described as a stack of functions
	* Define the signatures


## Catbook System

Architecture

	* Computer client - Web browser
	* Web server - http, urls to web pages
	* Application server - function interface
	* Database - CRUD for Profile, and Posts


Web Server Interface

	* Login

		* register (name, email, password, profile picture)
		* login (email, password)
	* Profile
	
		* add_post (profile, body/picture)
		* delete_post (post)
		* view_profile (profile)

	* Posts
		* view_post (profile, post)
		* comment_post (post)


Application Server Interface


	* Profile

		* CRUD - create, read, update, delete
	* Post

		* CRUD - create, read, update, delete


Database Schema


	* Profile

		* name, email, password, picture
	* Post

		* profile, content, thumbs ups, comments


Interfaces - Detailed Design

Start with Architecture (High-level Design)

	* Subsystems - partitioning of components
	* Interfaces - every subsystems has at least one interface
	* Data and control flow - walk the call chain


CatBook Application Server Interface (Functions)


* Profile

	* create_profile (name, email, password, picture)
	* update_user (name, email, password)
	* delete_user (email, password)

* Post

	* create_post (profile, content)
	* update_post (post)
	* delete_post (post)



Data

ORM


	* Define your database structures by specifying classes.  
	* Automatically generate SQL to match the objects.
	* All work is done in the object domain.


CatBook Data


* Profile

	* name, email, password
* Post

	* Profile, content, thumbs ups, comments
	

CatBook Classes


* Profile

	* name, email, password, picture
* Post

	* Profile, body


CatBook Functions for Data

	  # Post

	  def create_post (user, content):
	      Post.object.create (Profile, content)

	  def list_article (user_id):
	      return Article.objects.all()

	  def read_article (article_id):
	      return Article.objects.get(pk=article_id)

	  def update_article (user_id, title, body):
	      a = Article.objects.get (user_id=user_id, title=title)
	      a.body = body
	      a.save()

	  def delete_article (user_id, title):
	      Article.objects.delete(user_id=user_id, title=title)

