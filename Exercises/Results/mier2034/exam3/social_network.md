# Links to code
![Link to test code](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/exam3/social_network_crud.php)

![Link to implementation code](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/exam3/social_network_implementation.php)

# Front end interface

### Login/SignUp Page
![Index](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/images/1Home.JPG)

### Screen after hitting "Test All" button
![Test all](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/images/5test.JPG)

### SignUp Modal
![Sign Up](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/images/2SignUp.JPG)

### User Profile Page
![Home](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/images/3profile.JPG)

### User Profile Page Continued
![Home Continued](https://github.com/UNC-CS350/CS350/blob/master/Exercises/Results/mier2034/images/4profile_continued.JPG)




# Project Plan

### User registration

  *	Sign up/ Login Page
  
  *	Login functionality 
  
  * Logout functionality 

User story: A user visits the Facebook lite page. If they are a new user, they will be directed to the signup page. The user will then fill out a login form with some personal information. After the user is registered he or she will be able to login via the login page. When the user is done using the site, he or she should be able log out and terminate their session. 

## User friendships

  *	Add friend

  *	Remove friend

  *	Friends list

User story: A user wants to add a new friend, the user enters friends email and adds them as friends. If the user wants to delete a friend he can do so by eentering the friends email. The user will be displayed a list of all his friends.

## User topics

  *	Post topic on own profile

  *	Post topic on friends profile
  
  * Delete own topic
  
  * Delete topic posted on friends profile


User story: A user wants to express how her day is going with her friends. She then posts a topic for her friends to see, the user can delete the topic if she chooses too. The user wants to post a topic on her friends profileshe does this by entering the topic information and the friends email. She can also choose to delte that topic. 

# Design Plan:

## Architecture:
* Computer client - Web browser
* Web server - http, urls to web pages
* Application server - function interface
* Database - CRUD for User, Topics, Friends

## Interface:
### Web Server Interface:
* Login 
	* register (name, email, password)
	* login (email, password)
*User
	* add_topic(user, post)
	* delete_post (user, post) 
* Newsfeed
	* list_topics (user)
	* list_friens (user)
* Friendship
	* add_user(user)
	* delete_user(user)



### Web Server Interface (Functions)
* User
	* create_user (name, email, password)
	* read_user (name, password) --> user_id
	* list_user () --> user list
	* update_user (name, email, password)
	* delete_user (user_id)
* Post
	* create_topic (topic_id, topic)
	* list_topic (user_id)	
	* delete_topic (user_id)
* Friendship
	* add_user (user_id)
	* delete_user (user_id)
### Application Server Interface:
* User
	* CRUD - create, read, update, delete
* topic
	* CRUD - create, read, update, delete
* Friendship
	* CRUD - create, read, update, delete

### Database Schema
* User
	* firstname, lastname, email, password
* Topic
	* title, topic, author

* Friendship
	* user, user

## Data:
### Facebook Clone Data
* User
	* name, email, password
* Post
	* User, topics
* Friendship
	* User, User
	
### Facebook Clone Classes
* User
	* name, email, password
* Topic
	* User, topic
* Friendship
	* User, User



