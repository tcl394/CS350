Goal
Create a simple gui that shows posts form people the user is subscribed to.

Interfaces
  Web Client that Displays a GUI
  Backend Database

Architecture
  Computer Client - User's Web Browser
  Web Server - HTTPs, Urls, Possibly FTP
  Database - CRUD using SQL that manages Users, posts, etc.

Web Server Interface
  Log-In
    - Credentials (Username, Password)
    - Password Reset (Username, Email)
    - Username Reset (Email)
    - Create Account (Username, Password, Email, First Name, Last Name)
  Modify Posts
    - new_Post (Username, Title, Body, Attachment. DateTime, IP)
    - edit_Post (Post ID, Username, Title, Body, Attachment, DateTime, IP)
    - delete_Post (Post ID, DateTime, IP)
  Display Posts
    - get_Friends (Username)
    - get_Posts (Friends)
  Search Bar
    - find_Post(Search Term)
    
Database Schema
  - User: UserID, First Name, Last Name, Email, Username, Password (Salted Hash), CreatedDate
  - Post: PostID, Title, Body, Attachment, DateTime, EditID   
  - EditedPost: EditID, PostID, Title, Body, DateTime
  - Friends: UserID, UserID(Friend)
    
Data
  Objects
    User - ID, First Name, Last Name, Email, Username, Password, DateTime, Friends
      - Friends (Sub Object of User): UserID, Username
    Post - ID, Title, Body, Attachment, DateTime, RevisionID
    
    
    
