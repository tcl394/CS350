# Design Plan Exercise

## Architecture:

* Computer client - Browser
* Web server - 3rd Party Host
* Database - Microsoft SQL Server
* Application server - Function interface

## Interface:

### Web Server Interface:
* Log in 
	* register (email, username, password, name, phone_number)
	* login (username, password)
  * Recover Password (name, email, phone_number)
* User
	* add_post (username, post#)
	* delete_post (username, post#)
  	* friend_request(username, other_username)
* Home
	* show_feed(other_username)
	* comment_post (other_username, post#, comment)

### Application Server Interface:
* User - Microsoft SQL Database
* Post - Microsoft SQL Database
* Friendship - Microsoft SQL Database

### Database Schema:
* User
	* username, email, password, name, phone_number
* Post
	* username, post#, content
* Comment
	* post#, comment, other_username
* Friends
	* user, user
## Data:

### FB Clone Data:
* User
	* username, email, password, name, phone_number
	* Post
	* username, post#, comments
	
### FB Clone Classes:
* username
	* name, email, password
* Post
	* username, post#, comments
