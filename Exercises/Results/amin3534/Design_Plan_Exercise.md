Goal

Create a simple user interface that allows user to login/create profile, user can post text or pictures on homepage and can see posts from people that are friends, user can add profiles as friends, and user will be able to edit profile.




Interfaces

  Web Client that Displays a GUI

  Backend Database, most likely a .txt file




Architecture

  Computer Client - User's Web Browser

  Web Server - HTTPs, FTP

  Database - CRUD using .txt files that manages Users profiles and posts.




Web Server Interface

  Login Page:

    - Credentials (Username, Password)

    - Create Account (First name, Last name, Email, Username, Password, Confirm Password)
    
    - Button (Login)

  Profile Homepage:
  
    - sectionAboutSelf (userMajor, userMinor, hobbies)
    
    - CreatePost (Username, Title, Body, Attachment. DateTime)
    
    - EditPost (Post ID, Username, Title, Body, Attachment, DateTime)
    
    - DeletePost (Post ID, DateTime)
    
  Add Friends:
  
    - addfriends (username)
    
    - attachFriendToHomePage (username)
    
    - viewFriendsPosts (Username, Title, Body, Attachment)
    
    - deleteFriend (username)
    
  Edit Profile:
  
    - editPicture (attachment
    
    - editSectionAboutSelf (userMajor, userMinor, hobbies)
    
    - deleteProfile (delete users credentials from txt file along with all posts from other users)
    
    - editUserNamePassword (Username, Password, Confirm Password)
    
  Database Schema:
  - User: UserID, First Name, Last Name, Email, Username, Password.
  - Post: PostID, Title, Body, Attachment, DateTime, EditID   
  - EditedPost: EditID, PostID, Title, Body, DateTime
  - Friends: UserID, UserID(Friend)
    
Data
  Objects
    User - ID, First Name, Last Name, Email, Username, Password, DateTime, Friends
      - Friends (Sub Object of User): UserID, Username
    Post - ID, Title, Body, Attachment, DateTime, RevisionID

