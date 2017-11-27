* Language Used: C#
* IDE Used: Visual Studio 2017

# Design and Module Interface
There are two main classes, Social_Network.cs and Social_Network_Test.cs. Social_Network.cs contains four main other classes used by the front end; Person, Friend, Post, and MasterSystem. The person class has the Create_User and Lookup_User methods in it. The Friend class has the Add_Friend(), List_Friends(), and Remove_Friend() methods. The Post class has List_Topics(), AddTopic(), and RemoveTopic(). The MasterSystem class has MasterReset(), ExportData(), and ImportData(). I tested the MasterSystem methods by first exporting the data from my local CSV to a new CSV on my desktop, then using MasterReset() to wipe out the local bin CSV file. After verifying that the file was empty, I imported the data from the CSV on my desktop back to the CSV in my bin folder, and verified that all the information was restored. Social_Network_Test.cs contains a single test for each of the methods in the Social_Network.cs class, and has a single method that invokes every test.

# User Stories
### Creating A User
A user will give their Username and Password and an ID will be generated for them. That ID is what is used for the system to add friends and identify posts.
### Adding Friends
A user may want to become friends with another user. The system will use their unique user IDs for this purpose, and the user IDs will be saved to each other. The users only see each others' usernames.
### Viewing Friends
A user may want to see all of their friends. They can view a list of their friends, which is kept attatched to their ID. They can only see their friends' usernames.
### Removing Friends
A user may decide they no longer want to be friends with another. They can choose a friend to remove, and the system will remove their IDs from each other.
### Listing Topics
A user can see a list of every topic they have posted. This is done by the system tagging every topic posted with the ID of the user that posted it, and attaching it to their personal list of topics.
### Posting Topics
A user can add a topic to their list of topics. They provide the content of the topic, then the system tags the topic with their ID and adds it to their list.
### Removing Topics
A user can remove a topic from their list of topics. The system will take it off of the user's list, and the post will be gone.
### Resetting All Data
Perhaps the administrator is feeling sadistic (or just desparately needs to erase all data from the system). The administrator can use the MasterReset function to overwite the user_list.csv to a blank slate.
### Exporting Data
Perhaps before the administrator wipes everything clean, they want to save a backup of all the user data (who knows, they may sell it to the government). They can use the ExportData() function, which will make a copy of the local csv file to whatever path is provided.
### Importing Data
Since the data has been wiped, the administrator can use the ImportData() function to take the backup file that was copied before and overwite the local csv file, restoring all of the user information.

# Making Tests Fail
All tests were made sure that they could fail. A couple examples are below.
* Test_User_Create() Failure

---- DEBUG ASSERTION FAILED ----
---- Assert Short Message ----
User not properly created.
---- Assert Long Message ----

   at CS_350_Exam_3.Social_Network_Test.Test_User_Create() in C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\Social_Network_Test.cs:line 30
   at CS_350_Exam_3.Social_Network_Test.Main(String[] args) in C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\Social_Network_Test.cs:line 15
   
* Test_Master_Reset_UserInfo() Failure

---- DEBUG ASSERTION FAILED ----
---- Assert Short Message ----
User list not successfully reset.
---- Assert Long Message ----

   at CS_350_Exam_3.Social_Network_Test.Test_Master_Reset_UserInfo() in C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\Social_Network_Test.cs:line 43
   at CS_350_Exam_3.Social_Network_Test.Main(String[] args) in C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\Social_Network_Test.cs:line 17

# Runtime Log
'social_network_app.exe' (CLR v4.0.30319: DefaultDomain): Loaded 'C:\WINDOWS\Microsoft.Net\assembly\GAC_32\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
'social_network_app.exe' (CLR v4.0.30319: DefaultDomain): Loaded 'C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\bin\Debug\social_network_app.exe'. Symbols loaded.
'social_network_app.exe' (CLR v4.0.30319: social_network_app.exe): Loaded 'C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
The program '[13596] social_network_app.exe' has exited with code 0 (0x0).
The program '[13596] social_network_app.exe: Program Trace' has exited with code 0 (0x0).
