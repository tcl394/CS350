#Design Plan

##Architecture

Web Browser, Client Side
Web Server / Https
Database - txt files

##Web Server Interface

*Person
register(name, email, password)
login(email, password)

*Friend
add_friend(email)
remove_friend(email)
show_friends(user)

*Post
post_add(user_ID, post)
post_delete(user_ID, post_ID)
post_comment(user_ID, post_ID, comment)
show_post_comments(user_ID, post_ID, comment_ID)

*System
sys_reset()
sys_export(path)
sys_import(path)

##Functions

*Person

public class user:
	str Name;
	str email;
	int userID;
	str pass;
	
	getters and setters
	
	create_user(name,email,password)
		creates a new user
	validate_user(email, password)
		used for sign in
		
	add_friend(email)
		adds a pairing to the friends.txt file
	
	remove_friend(email)
		removes a pairing from the friends.txt file
		
	show_friends(userID)
		lists all a users friends
		
*Post

public class post:
	
	str content;
	str userID;
	str postID;
	
	getters and setters
	
	show_posts(userID)
		lists all posts by user
		
	create_post(userID, post)
		content = post
		total_posts =+ 1
		postID = total_posts
		creates a post for a user and adds it to the posts.txt file
	
	remove_post(userID, post_ID)
		removes a post from the posts.txt file

*System

sys_reset()
	finds all .txt files and deletes them

sys_export(path)
	exports all .txt files to the specified folder
	
sys_import(path))
	imports all .txt files from a specified folder, should check for names friends.txt, users.txt, posts.txt
	
	




	
	
	












