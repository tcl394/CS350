## Social Network Application

Architecture


	* Web browser
	* Web server
	* Email serviec
	* function interface
	* CRUD for User, Post Authoring, Collective Network

Web Server Interface

	* Login
		* register (name, email, id, password) - saved user info
		* login (name, password) - user varification
		* biography (title, body) - about the user
		* addPicture(profileImage) - picture of the user
	
	* User Security	
		* postViewFriend(authorizedFriend)
		* postViewGlobal(authorizedGlobalAccess)
		* postViewSelf(authorizeSelfView)

	* User Post Authoring
		* addPost (user, title, body)
		* editPost (user,title, body)
		* deletePost (user,title, date)
		
	* Collective Network Wall

		* getFriends (friends)
		* getFriendPosts (friends, date, title)
		* searchFriend (searchName)
		* addFriend (searchName)




Database Setup


	* User

		* name, email, password, biography, age, image, friends
	* User Security

		* friend viewable account, global viewable account, none viewable account
	* User Post Authoring
		
		* name, date, body
	* Collective Network Wall

		* friends, date, body, search name
		
		
Application Server Interface


	* User

		* CRUD - create, read, update, delete
		
	* User Security
		
		*CRUD - create, read, update, delete
		
	* User Post Authoring

		* CRUD - create, read, update, delete
		
	* Collective Network Wall

		* CRUD - create, read, update, delete


-------------------------------------------
Interfaces - Detailed Design


Social Network Web Server Interface 


* Login

	* register (name, email, id, password)
	* login (name, password)
	* biography (about)
	* profilePicture (profileImage)
* User Security

	* postViewFriend(authorizedFriend)
	* postViewGlobal(authorizedGlobalAccess)
	* postViewSelf(authorizeSelfView)
* User Post Authoring

	* addPost (user,title, body)
	* editPost (user,title, body)
	* deletePost (user, title)
* Collective Network Wall

	* friends (friends)
	* friendPost (friends, date, title)
	* searchFriend (searchName)
	* addFriend (searchName)


Social Network Application Server Interface (Functions)


* User

	* createUser (name, email, id, password)
	* updateUser (name, email, password)
	* readUser (name, id, password)
	* deleteUser (userId)
	* addBiography (body)
	* editBiography (body)
	* deleteBiogrpahy (body)
	* addProfilePicture (profilePicture)
	* changeProfilePicture (profilePicture)
	* deleteProfilePicture (profilePicture)
	
* User Security
	
	* postViewFriend(authorizedFriend)
	* postViewGlobal(authorizedGlobalAccess)
	* postViewSelf(authorizeSelfView)
	
* User Post Authoring
	
	* addPost (user, title, body, date)
	* editPost (user, title, body, date)
	* deletePost (user,title date)

* Collective Network Wall

	* getFriends (friends)
	* getFriendPosts (friends, date, title)
	* searchFriend (searchName)
	* addFriend (searchName)



Data

Social Network Data


* User

	* name, email, password, biography, picture
* User Security

	* authorizedFriend, authorizedGlobalAccess, authorizeSelfView
* User Post

	* user, title, body, date
* Collective Network Wall

	* friends, date, body, searchId, searchName
