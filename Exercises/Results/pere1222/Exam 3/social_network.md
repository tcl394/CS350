* Language Used: Java, PHP, mySQL, JavaScript, CSS and HTML
* IDE Used: Eclipse

# Design and Module Interface
There are three main classes that test the mySQL database: database.java, DBConnector.java, and Users.java along with the social_network_test.class.
In the folder Preezbook you will find the PHP, JavaScript, CSS and HTML to create the front-end. 


# User Stories
### Creating A User
A user will give their Username and Password and an ID will be generated for them. That ID is what is used for the system to add friends and identify posts.
### Adding Friends
A user may want to become friends with another user. The system will use their unique user IDs for this purpose, and the user IDs will be saved to each other. The users only see each others' usernames.
### Viewing Friends
A user may want to see all of their friends. They can view a list of their friends, which is kept attatched to their ID. They can only see their friends' usernames.
### Removing Friends
A user may decide they no longer want to be friends with another. They can choose a friend to remove, and the system will remove their IDs from each other.

# Topics (Post) Stories
### Listing Topics
A user can see a list of every topic they have posted. This is done by the system tagging every topic posted with the ID of the user that posted it, and attaching it to their personal list of topics.
### Posting Topics
A user can add a topic to their list of topics. They provide the content of the topic, then the system tags the topic with their ID and adds it to their list.
### Removing Topics
A user can remove a topic from their list of topics. The system will take it off of the user's list, and the post will be gone.

# System stories
### Resetting All Data
Perhaps the administrator is feeling sadistic (or just desparately needs to erase all data from the system). The administrator can use the MasterReset function to overwite the user_list.csv to a blank slate.
### Exporting Data
Perhaps before the administrator wipes everything clean, they want to save a backup of all the user data (who knows, they may sell it to the government). They can use the ExportData() function, which will make a copy of the local csv file to whatever path is provided.
### Importing Data
Since the data has been wiped, the administrator can use the ImportData() function to take the backup file that was copied before and overwite the local csv file, restoring all of the user information.

# Making Tests Fail
All tests were made sure that they could fail. 



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
* Post (Topic)
	* idpost, senderid, receiverid, text

* Friendship
	* user, user


## Classes and functions:

* Database class:
	* Backup()
	* Import()
	* EraseAllData()
	
* DBConnector class:
	* Connect()
	* ShowsTable(String tableName)

* Users class:
	* RegisterUser(String firstname, String lastname, String email, String password)
	* ListofFriends(String id)
	* makeFriends(String userid, String friendid)
	* eraseFriendship(String userid, String friendid)
	* ShowPosts(String receiverid)
	* addPostFrom(String senderid, String receiverid, String text)
	* erasePost(String postid)
	
* social_network_test class


