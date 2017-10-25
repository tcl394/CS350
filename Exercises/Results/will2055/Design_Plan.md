## Social Networking Application

Architecture


	* Computer client - Web browser
	* Web server - http, urls to web pages
	* Email server - SMTP
	* Application server - function interface
	* Database - CRUD for User, Post Authoring, Collective Network

Web Server Interface


	* Login

		* register (name, email, password)
		* login (name, password)
		* add_bio(body)
		* add_age(age)
		* add_picture(profile_image)
	* User Security
		
		* post_view_friend(f_authorize)
		* post_view_global(g_authorize)
		* post_view_self(n_authorize)

	* User Post Authoring

		* add_post (user, body)
		* edit_post (user, body)
		* delete_post (user, date)
	* Collective Network Wall

		* get_friends (friends)
		* get_friend_post (friends, date, body)
		* search_friend (search_name)
		* add_friend (search_name)


Application Server Interface


	* User

		* CRUD - create, read, update, delete
	* User Security
		
		*CRUD - create, read, update, delete
	* User Post Authoring

		* CRUD - create, read, update, delete
	* Collective Network Wall

		* CRUD - create, read, update, delete


Database Schema


	* User

		* name, email, password, biography, age, image, friends
	* User Security

		* friend viewable account, global viewable account, none viewable account
	* User Post Authoring
		
		* name, date, body
	* Collective Network Wall

		* friends, date, body, search name



Interfaces - Detailed Design


Social Network Web Server Interface 


* Login

	* register (name, email, password)
	* login (name, password)
	* biography (body)
	* age (age)
	* profile_picture(profile_image)
* User Security

	* account_view_friend (f_authorize)
	* account_view_global (g_authorize)
	* account_view_self (n_authorize)
* User Post Authoring

	* add_post (user, body)
	* edit_post (user, body)
	* delete_post (user, title)
* Collective Network Wall

	* friends (friends)
	* friend_post (friends, date, body)
	* search_friend (search_name)
	* add_friend (search_name)


Social Network Application Server Interface (Functions)


* User

	* create_user (name, email, password, age)
	* update_user (name, email, password, age)
	* read_user (name, password)
	* delete_user (user_id)
	* add_biography (body)
	* edit_biography (body)
	* delete_biogrpahy (body)
	* edit_age (age)
	* add_profile_picture (profile picture)
	* edit_profile_picture (profile picture)
	* delete_profile_picture (profile picture)
	
* User Security
	
	* account_view_friend (f_authorize)
	* account_view_global (g_authorize)
	* account_view_self (n_authorize)
	
* User Post Authoring
	
	* add_post (user, body, date)
	* edit_post (user, body, date)
	* delete_post (user, date)

* Collective Network Wall

	* get_friends (friends)
	* get_friend_post (friends, date, body)
	* search_friend (search_name)
	* add_friend (search_name)



Data

Social Network Data


* User

	* name, email, password, age, biography, picture
* User Security

	* f_authorize, g_authorize, n_authorize --> boolean conditions
* User Post

	* user, body, date
* Collective Network Wall

	* friends, date, body, search_name
