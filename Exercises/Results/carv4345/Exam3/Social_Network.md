Social_Network.md
// Written by Robert Carver 11/20/17 - 11/26/17 for CS350. 
# Overview
	Namespace Object Classes:
		- User
		- Post

	SocialMedia Class Methods:
		- Booleans
			* UserLogin
			* InitUser
			* InitPost
			* Export Data
			* Import Data
			* ResetSystem
			* DeleteUser
			* DeletePost
			* AddFriend
			* DeleteFriend
		- Lists
			* GetFriends
			* GetFriendPOsts
		- Voids
			* TestAll

# Object Class Description
Both object classes contain methods and variables to maintain a user and a post object. The objects are used by the social media class to construct new users and new posts associated with users. 
## User
### Public Variables
* First - string
	* User first name
* Last - string
	* User last name
* Email - string
	* The accounts email
* Uid - string
	* The user identification number. Unique to each user. 
* Posts - list
	* A list of integers that contains the pID of all the the users posts.
* Friends - list
	* A list of strings that contains the Uid of each friend of the user. 

### Public Functions
* User
	* Constructor, takes 4 strings and 2 lists as input. 
* AddPost
	* Parameters: int ID
	* Return: void
* RemovePost
	* Parameters: int ID
	* Return: void
* AddFriend
	* Parameters: string f
	* Return: void
* RemoveFriend
	* Parameters: string f
	* Return: void

## Post
### Public Variables
* PID - int
	* Post ID generated on the fly.
* Content - string
	* Content of the post.
* Timestamp - string
	* Time the post object was created (yyyy-MM-dd HH:mm:ss.ffffff).
* TaggedUsers - string
	* The users that are tagged in the post.
* ownerID - string
	* The Uid of the posts creator. 

### Public Functions
* Post
	* Constructor, takes 1 int and 4 strings.
* Gets and Sets for each variable. 

# Social Media Class Description
The social media class contains two lists and a currentUser that is logged in once verified. All methods return something whether it be a boolean value or a list, web interface can easily determine from boolean values whether the method has ran correctly. The export and import methods save and load all user and post data to and from a .txt file. 

### Public Variables 
* users - List
	* A list of User objects. 
* posts - List
	* A list of Post objects. 
* currentUID - User
	* A logged in user. 

### Public Functions
* UserLogin
	* Parameters: string uid, string password
	* Return: bool
	* Description: Validates password against the UID and changes currentUId to UID if true. 
* InitUser
	* Parameters: string UID, string first, string last, string email, List posts, List friends
	* Return: bool
	* Description: Initializes a new User object with the given parameters and inserts the new User into the users list. 
* InitPost
	* Parameters: string content, string tagged, string oID
	* Return: bool
	* Description: Initializes a new Post object with the given parameters and inserts the new Post into the posts list & generates a post ID. 
* ExportData
	* Parameters: none
	* Return: bool
	* Description: Writes the users and posts lists to a symbol delimited txt file. 
* ImportData
	* Parameters: None
	* Return: bool
	* Description: Reads a symbol delimited txt file to initialize the contents of the users and posts lists.
* ResetSystem
	* Parameters: None
	* Return: bool
	* Description: Clears the users and symbols lists. 
* DeleteUser
	* Parameters: string uid
	* Return: bool
	* Description: Verifies the given User object exists and removes it from the users list. 
* DeletePost
	* Parameters: int pid, string uid
	* Return: bool
	* Description: Verifies the given Post object exists and removes it from both the posts list and the post list of the user using the USer object method removerPost. 
* AddFriend
	* Parameters: string uid, string friendUID
	* Return: bool
	* Description: Calls the addFriend method of the User object to add the friendUID to the friend list of the User and the uid to the friend list of the target friend. 
* DeleteFriend 
	* Parameters: string uid, string friendUID
	* Return: bool
	* Description: Calls the removeFriend method of the User object to remove the friend ID's from both the uid and friendUID users friend lists. 
* GetFriends
	* Parameters: string uid
	* Return: List
	* Description: Retrieves a list of the Uid's of all a users friends. 
* GetFriendPosts
	* Parameters: string uid
	* Return: List
	* Description: Retrieves a list of the Pid's of all a users friends posts.  
* TestAll(Only found in social_network_test.cs)
	* Parameters: None
	* Return: Console Output
	* Description: Runs a verbose check of all of the above methods, verifying they work. 

TestAll() method output:

	Initiate user 1: True
	Login user: True
	Initiate user 2: True
	Initiate user 3: True
	Initiate user 4: True
	Initiate post 1: True
	Initiate post 2: True
	Initiate post 3: True
	Friend users: True
	Friend users: True
	Delete friend: True
	Delete Post: True
	Delete User: True
	Enter to continue test

	Export system data: True
	Enter to continue test

	Reset system: True
	Enter to continue test

	Import data: True

	Retrieve friends: 123,321
	Retrieve friends posts: 2,2

	Test Complete.

Visual Studio Build Log:

	Restoring NuGet packages...
	To prevent NuGet from restoring packages during build, open the Visual Studio Options dialog, click on the Package Manager node and uncheck 'Allow NuGet to download missing packages during build.'
	1>------ Build started: Project: unitTest, Configuration: Debug Any CPU ------
	1>unitTest -> f:\Documents\Visual Studio 2017\Projects\unitTest\unitTest\bin\Debug\netcoreapp2.0\unitTest.dll
	========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========


Visual Studio Debug Log:

	'dotnet.exe' (CoreCLR: DefaultDomain): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Private.CoreLib.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'f:\Documents\Visual Studio 2017\Projects\unitTest\unitTest\bin\Debug\netcoreapp2.0\unitTest.dll'. Symbols loaded.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Runtime.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Collections.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Console.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Threading.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Runtime.Extensions.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'dotnet.exe' (CoreCLR: clrhost): Loaded 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.0.0\System.Linq.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	Exception thrown: 'System.NullReferenceException' in unitTest.dll
	Exception thrown: 'System.NullReferenceException' in unitTest.dll
	The program '[10180] dotnet.exe' has exited with code 0 (0x0).

	
