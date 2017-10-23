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
* User
	* create_user (name, email, password)
	* read_user (name, password) --> user_id
	* list_user () --> user list
	* update_user (name, email, password)
	* delete_user (user_id)
* Post
	* create_post (post_id, post)
	* read_post (post_id)
	* comment_post (post_id, user_id, comment)
	* list_post (user_id)	
	* update_post (user_id, post)
	* delete_post (user_id)
* Friendship
	* follow_user (user_id)
	* unfollow_user (user_id)
### Application Server Interface:
* User
	* CRUD - create, read, update, delete
* Post
	* CRUD - create, read, update, delete
* Friendship
	* CRUD - create, read, update, delete

### Database Schema
* User
	* name, email, password
* Post
	* user, body, likes
*Comment
	* post, comment
* Friendship
	* user, user

## Data:
### Facebook Clone Data
* User
	* name, email, password
	* Post
	* User, post, comments
* Friendship
	* User, User
	
### Facebook Clone Classes
* User
	* name, email, password
* Post
	* User, post, comments
* Friendship
	* User, User



