# Design Plan:

## Architecture:
* Computer client - Web browser
* Web server - http, urls to web pages
* Application server - function interface
* Database - CRUD for User, Status, Friends

## Interface:
### Web Server Interface:
* Login 
	* register (name, email, password)
	* login (name, password)
*User
	* add_post (user, post)
	* edit_post (user, post)
	* delete_post (user, post) 
* comment_post(user, post, comment)
* Newsfeed
	* get_posts (user)
	* comment_post (user, post, comment)
* Friendship
	*follow_user(user)
	*unfollow_user(user)



### Web Server Interface (Functions)
*	User
o	create_user (name, email, password)
o	read_user (name, password) --> user_id
o	list_user () --> user list
o	update_user (name, email, password)
o	delete_user (user_id)
•	Post
o	create_post (post_id, post)
o	read_post (post_id)
o	comment_post (post_id, user_id, comment)
o	list_post (user_id)	
o	update_post (user_id, post)
o	delete_post (user_id)
•	Friendship
o	follow_user (user_id)
o	unfollow_user (user_id)
Application Server Interface:
* User
	* CRUD - create, read, update, delete
* Post
	* CRUD - create, read, update, delete
* Friendship
	* CRUD - create, read, update, delete

Database Schema
* User
	* name, email, password
* Post
	* user, body, likes
*Comment
	* post, comment
* Friendship
	* user, user

Data:
Facebook Clone Data
•	User
o	name, email, password
•	Post
o	User, post, comments
•	Friendship
o	User, User
Facebook Clone Classes
•	User
o	name, email, password
•	Post
o	User, post, comments
•	Friendship
o	User, User



