# Design plan

Design Plan
Architecture
	Computer client – web browser
	Web server – http, urls to web pages
	Email server – SMTP
	Application server – function interface
	Database – CRUD for User, Article, subscriber
Web Server Interface
	Login
Register (name, email, password)
Login (name, password)
	Author
add_post (user, title, body)
edit_post (user, title, body)
delete_post(user, title)
	Reader
get_post (title)
list_post (user)
	News
Register (email)
verify_email (token)
unsubscribe (email)
Application Server interface
	User
CRUD – create, read, update, delete
	Article
CRUD – create, read, update, delete
	Subscriber
CRUD – create, read, update, delete
Database Schema
	User
name, mail, password
	Article
user, title, body
	Subscriber
email, user
Interfaces - Detailed Design
Start with Architecture (High-level Design)
	Subsystems – partitioning of components
	Interfaces – every subsystem has at least one interface
	Data and control flow – walk the call chain
Old folks facebook Web Server Interface
	Login
register (name, email, password)
login (name, password)
	Author
add_post (user, title, body)
edit_post (user, title, body)
delete_post (user, title)
	Reader
get_post (title)
list_posts (user)
	News
register (email)
verify_email (token)
unsubscribe (email)
Old folks facebook Application Server Interface (Functions)
	User
create_user (name, email, password)
read_user (name, password) --> user_id
list_user () --> user list
update_user (name, email, password)
delete_user (user_id)
	Article
create_article (user_id, title, body)
read_article (article_id)
list_article (user_id)
update_article (user_id, title, body)
delete_article (user_id)
Data
ORM
	Define your database structures by specifying classes
	Automatically generate SQL to match the objects
	All work is done in the object domain
Old Folks Facebook Data
	User
name, email, password
	Post
user, title, body
	Subscriber
email, user
Old Folks Facebook Classes
	User
name, email, password
	Post
user, title, body
	Subscriber
	email, user
Old Folks Facebook Functions for Data
Article
def create article (user id, title, body)
         Article.object,create (user_id, title, body)
def list_article (user_id)
   reture Article,objects,all()
def read_article (article_id)
   return Article,objects,get(pk=article_id)
def update_article (user_id, title, body)
   a = Article,objects,get (user_id = user_id, title=title)
a.body = body
   a.save()
def delete article (user_id, title)
   Article.objects.delete(user.id=user.id, title = title)

