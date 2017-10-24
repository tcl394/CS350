
Design Plan Exercise
Goal
Create simple homepage with recent info from groups the user subscribes to.
Architecture
Interfaces
-	Web client interface
-	Database Interface (Webserver to DB)

Architecture
- Users – web browser
- Web Server – http, url’s, etc
- Database – CRUD for User, Groups

Web Server Interface
•	Log-in 
o	LogIn(Username, Password)
o	PWReset(Username, Email)
o	Register(Username, Email, Password)
o	LockAcct(Username)
•	Home Screen (Prototype)
o	Welcome(Username)
o	NavMenu()
o	Events(Username, SystemTime)
o	LogOut(Username, SystemTime)
•	Profile Screen
o	Profile(Username)
o	EditInfo(Username, NewInfo)
o	LastUpdate(Username, SystemTime)
o	Pic(Username)
•	Groups
o	Subscribe(Username, GrpName)
o	UnSubscribe(Username, GrpName)
o	GrpActivity(GrpName,  SystemTime)
o	Notify(Username, GrpName, ActivityName, SystemTime)
Database Schema
-	User 
o	FirstName
o	LastName
o	UserName

-	Group
o	GrpName
o	Posts
o	SubscriberList

-	Subscribe
o	User
o	GrpName

-	Post
o	User
o	GrpName
o	PostBody

Interfaces - Detailed Design
-	Login
o	RegisterUser(Name, UserName, Email, Password)
o	Login(UserName, Password)
-	Home
o	FetchPosts(UserName, SubscribedList)
o	MakePost(UserName, PostTitle, PostBody)
o	AddGroup(UserName, GroupName)
-	Profile
o	GetUserData(UserName)
o	UpdateUserData(UserName, NewData)
o	DeleteUser(UserName)
-	Group
o	MakePost(UserName, PostTitle, PostBody)
o	Unsubscribe(UserName)
FaceClone Classes
-	User
o	UserName
o	Password
-	Post
o	UserName
o	PostTitle
o	Body
-	Subscriber
o	UserName
-	Group
o	GroupName
o	Posts

Data – ORM
FaceClone Data
-	User
o	Name
o	UserName
o	Email
o	Password
-	Post
o	UserName
o	PostTitle
o	PostBody
-	Group
o	UsersList
o	Posts
FaceClone Functions for Data
Public void Create_Post(UserName, PostBody){
	Post User_Post = new Post(UserName, PostBody);
	DB.WriteTo();
}
Public string Read_Post(UserName, PostTitle){
	Return PostTitle.Body();
}
Public string Update_Post(UserName, PostTitle, NewBody){
	String CurrentBody = PostTitle.getBody();
	CurrentBody = NewBody;
	PostTitle.updateBody();
	Return CurrentBody;
}
Public void Delete_Post(UserName, PostTitle){
	PostTitle.deletePost();
}
	

