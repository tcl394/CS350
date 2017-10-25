# Design Plan Exercise - Toller
## Facebook Lite System
Web Server Interface
Login
  *	register (name, email, password)
  *	login (name, password)
User
  *	add_post (user, timestamp, text)
  *	delete_post (user, timestamp)
  *	post_comment (user, timestamp, text)
Friends
  *	find_friend (name)
  *	friend_request (name)
  *	accept_request (friend_request)
  *	decline_request (friend_request)
Application Server Interface (Functions)
User
  *	create_user (name, email, password)
  *	read_user (name, password) --> user_id
  *	edit_user (name, email, password)
  *	delete_user (user_id)
Post
  *	create_post (user_id, timestamp, text)
  *	list_post (user_id)
  *	delete_post (user_id)
  *	post_comment (user, timestamp, text)
Data
User
  *	name, email, password
Post
  *	user, timestamp, text, comments
Classes
User
  *	name, email, password
Post
  *	user, timestamp, text, comments

