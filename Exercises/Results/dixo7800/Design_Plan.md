Design Plan  
   Shawn Dixon  
   10/21/17  

#Architecture
	* Computer Client – Client Web Browser
	* Web Server – URLs for application
	* Application Server – Functional Interface for Database data entry.
	* Database – CRUD:  Profile, Pages, Threading, Following

#Interfaces
	##Computer Client Interface
		 * Standard Web Browser
	##Web Server Interface
		* Profile
			*  Sign-up (username, email, password)
			*  Login (username, password)
		* Page_Creator
			*  Add_Page (username, title, body)
			*  Edit_Page (username, title, body)
			*  Delete_Page (username, title, body)
		* Follower
			*  Get_Page (title)
			*  Follow_Page (title, username)
	##Application Server Interface
		* User – CRUD – create, read, update, delete
		* Page – CRUD – create, read, update, delete
		* Follower – CRUD – create, read, update, delete
	##Database Schema
		* User
			*  Username, email, password, first_name, last_name
		*Page
			*  User, title, body
		*Follower
			*  Username, email, page
#Data
	##Project Data
    *  User
			*  Username, email, password, first_name, last_name
		* Page
			*  User, title, body
		* Follower
			*  Username, email, page

	##Project Classes
    * User
			*  Username, email, password, first_name, last_name
		* Page
			*  User, title, body
		* Follower
			*  Username, email, page

	##Project Functions for Data
		* Pages
			Public static createPage (username, title){
			}
			Public static editPage (username, title, body){
			}
			Public static deletePage (username, title){
			}
			Public static getPage (title){
			}

