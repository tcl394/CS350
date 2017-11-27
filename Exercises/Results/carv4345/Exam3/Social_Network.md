Social_Network.md
// Written by Robert Carver 11/20/17 - 11/26/17 for CS350. 

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

The social media class contains two lists and a currentUser that is logged in once verified. All methods return something whether it be a boolean value or a list, web interface can easily determine from boolean values whether the method has ran correctly. 

The export and import methods save and load all user and post data to and from a .txt file. 

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

	
