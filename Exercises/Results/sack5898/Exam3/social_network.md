# Documentation for Exam 3 Social Network

## Purpose

The purpose of this document is to establish the Minimum Viable Product for a Social Network Website (SNW) for Exam 3.

### User
*	The SNW will have a Log-in page where users can access existing accounts or create a new one.
*	Users will create accounts with a username and password.

### Post
*	Users will be able to create text posts for friends to see.
*	Posts can be edited and deleted.
* Users can list all posts for another user.

### Friendship
*	Users will have their own Friends list where they can link with other users.
*	Requests to link as friends can be sent and link will be complete when the other user accepts.

### System
* All data will be written to and pulled from a single spreadsheet


## User Stories

### User

As an SNW user, I want to be able to create a new account for SMT. When I first open SMT there should be obvious text entry sections where I can type a username and password to create and account.

### Post

As an SNW user, I would like to be able to create text posts for other users to see. I would like to be able to edit these posts if I make a mistake, or delete them if need be. I would like to be able to see other posts from my friends.

### Friendship

As an SNW user, I want a list of my current friends. I want this page to contain a search feature to find new friends. I would like to be able to deny friend requests from other users if I do not know them.

### System

The SNW system will have all data stored in an excel spreadsheet that can be used to import data, export data to, and can be reset if needed

## Architecture


* Computer client - Web browser
* Web server - http, urls to web pages
* Email server - SMTP
* Application server - function interface
* Database - CRUD for User, Post, Friend


Web Server Interface

* User
  * create_user (firstName, lastName, userID)
  * set_user (userID)

* Post
  * create_post (postID, postText)
  * edit_post (postID, newText)
  * delete_post (postID)
  * list_posts (user)
  
* Friendship
  * add_friendship (user1, user2)
  * list_friends (user)
  * remove_friendship (user1, user2)
  
* System
  * export_data ()
  * import_data ()
  * reset_data ()

Application Server Interface


* User

	* CRUD - create, read, update, delete
* Post

	* CRUD - create, read, update, delete
* Friend

	* CRUD - create, read, update, delete


Database Schema


* User

	* name, userID
* Post

	* user, post_id, body
* Friend

	* user_id1, user_id2



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

	* name, userID
* Post

	* user, post_id, body
* Friend

	* user1, user2
