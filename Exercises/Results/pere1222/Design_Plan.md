# Design Plan:

## Architecture:
* Computer client - Browser
* Web server - Amazon Web Services
* Application server - Function interface
* Database - Microsoft SQL Server

## Interface:
### Web Server Interface:
* Log in 
	* register (name, email, password)
	* login (name, password)
  * Recover Password (name, email)
* User
	* add_post (name, post#)
  * comment_post(name, post#, comment)
	* edit_post (name, post#)
	* delete_post (name, post#)
  * friendship_Request_List(name_of_request,number_of_requests)
* Home
	* get_posts (name)
	* comment_post (name, post, comment)
* Add Friends
	* follow_user(name)
	* unfollow_user(name)



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
  
* Friendship List
	* follow_user (user_id)
	* unfollow_user (user_id)
  
### Application Server Interface:
* User
	* Microsoft SQL Database
* Post
	* Microsoft SQL Database
* Friendship
	* Microsoft SQL Database

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



