
## Design Plan
  
### Facebook Life System
### Architecture
	•	Computer Client 	: Web Browsers (Chrome, Mozilla Firefox, Internet Explorer (Microsoft 
					  Edges), Safari, etc.) 
	•	Web Server		: Http, Https, URLs to web pages
	•	Email Server		: SMTP
	•	Application Server	: Functions interfaces
	•	Database		: Create – Read – Update – Delete for Users, Moderators, Posts

### Interfaces
#### Web Server:
	Login
		* sign_up (userID, username, email, password)
		* login (userID, username, password)
		* forgot_password (userID, username/email, secret questions)

	Users
		* create_post (username, post_id, title, text_area)
		* edit_post (username, post_id, title, text_area)
		* delete_post (username, post_id, title)
		* share_post (username, post_id, title)
		* read_post (username, title, text_area)

	Moderators
		* create_post (moderator, post_id, title, text_area)
		* edit_post (moderator, post_id, title)
		* read_post (username, title, text_area)
		* delete_post (moderator, post_id, title)
		* alter_user_account (moderator, username)

	New Feed
		* register (email)
		* verify_account (token)
		* deactivate_account (email, status)

#### Application Server:
	Users
		* Create – Read – Update – Share – Delete 
	Moderators
		* Create – Read – Update – Share – Delete
		* Alter_user_account
	Posts
		* Create – Read – Update – Share – Delete 

#### Database Schema:
	Users
		* userID, username, email, password, secret_questions
	Moderators
		* moderatorsID, username, email, password, secret_questions
	Posts
		* post_id, title, date, text, username

#### Functions:
-	Users
	user_register (userID, username, email, password, secret_questions)
	user_login (userID, username, password)
	user_list ()
	update_user (email, password, secret_questions)
	user_forgot_username (email_secret_questions)
	user_forgot_password (email, secret_questions)
	deactivate_user (userID, username, password, secret_questions)

-	Moderators
	create_user (moderatorID, username, email, temp_password)
	update_user_account (userID)
	delete_user_account (userID)
-	Posts
	create_post (userID, title, text_area)
	read_post (userID, title, text_area)
	update_post (userID, title, text_area)
	delete_post (userID, moderatorID)
	list_post (userID, moderatorID)

### Data
•	User
o	userID, username, email, password, secret_question
•	Moderator
o	moderatorID, username, email, password, secret_question
•	Post
o	postID, userID, username, title, text_area

#### Functions for Data
•	User, Moderator
o	Def register
	 OleDbConnection conn = new OleDbConnection();
	conn.ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();
	conn.Open();
	OleDbCommand cmd = new OleDbCommand();
	cmd.CommandText = "insert into [userTbl](column1, column2, column3, column)values(@name,@email,@password,@secret_question)";
	cmd.Parameters.AddWithValue("@name", name.Text);
	cmd.Parameters.AddWithValue("@email", email.Text);
	cmd.Parameters.AddWithValue("@password", password.Text);
	cmd.Parameters.AddWithValue("@secret_question", secret_question.Text);
	cmd.Connection = conn;
	cmd.ExecuteNonQuery();
	conn.Close();
o	Def update
	cmd.CommandText = "UPDATE [userTbl] SET column1 = @name, column2  = @email, column3 = @password, column4 = @secret_question WHERE userID = userID";
o	Def delete
	cmd.CommandText = “DELETE FROM [userTbl] WHERE condition; 
o	Def reset_password
	cmd.CommandText = "UPDATE [userTbl] SET column3 = @newpassword , WHERE userID = userID";
	
•	Post
o	Def create_post (userID, username, title, text_area)
	Create post (userID, username, title, text_area)
o	Def update_post (userID, title, text_area)
	Update post (userID, postID, title, text_area)
o	Def delete_post (userID, postID, title)
	Delete post (userID, postID, title)
o	Def share_post (userID, postID, username, title)
	Share post (userID, postID, title)
o	Def list_post (userID, postID, username, title)
	List post (userID, postID, username, title)

