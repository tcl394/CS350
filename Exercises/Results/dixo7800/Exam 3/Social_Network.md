Shawn Dixon
CS350
11/22/17
Dr. Seaman

Exam 3

For this exam, I decided to use C# as my language of choice on the .NET framework. I did this because I feel most comfortable in that environment and I am most comfortable with Visual Studio. 

Since the assignment had ambiguity I think it is best if I explain the choices I made. First off, when it came to posts, I thought of the social networking site as if it was like Reddit. So, I used the topic of the post as if it was a thread topic on Reddit. Then I added in a title, author, and body to round out the properties of the Post class. The only other class based decision that was different was the idea of having a Friends list of type person, versus having a person list of type friend. The other classes, I felt were straight forward and easy to implement, such as a person has a first and last name, an email, a username and a password.
The only other real choice I made, was originally I was going to make a WPF application, but the instructions stated that we needed something that could be used by a front end, and did not state that a front end needed to be made. Furthermore, I realized that I was not going to have enough time to make an entire application in such a short amount of time.

A few notes: the results will be shown in stages, as running all tests will automatically end up deleting all the files in the end. If you would like to run the application for yourself, it should be noted that all the files will be added to your desktop. Another note, is that all the data is exported out to a different set of files, then that data is re-imported back in. I do not have a second set of data to load in, as I felt that exporting the data out, and re-importing the data displays the full capability of that functionality.

The Results are below. 

•	Note: All of the files are saved to the desktop. The files to look for are as follows:
•	Social_Networking_Users.txt
•	Social_Networking_Friends.txt
•	Social_Networking_Posts.txt
•	Users.txt (used for exporting and importing testing)
•	Friends.txt (used for exporting and importing testing)
•	Posts.txt (used for exporting and importing testing)

Output from Runtime:

  
  

Registration Test:

 

Social_Networking_Users.txt 

Login Test:

 

Social_Networking_Users.txt
 

Adding Friends Test:

 

Social_Networking_Friends.txt
 

Listing Friends Test:
 

Social_Networking_Friends.txt
 

Removing Friends Test:

 

Social_Networking_Friends.txt
 
Adding Topic Test:
 

Social_Networking_Posts.txt
 

Listing Topics Test:
*Note the topics and the titles are displayed, otherwise it is possible to have two topics of the same name, which does not give enough detail.

 

Social_Networking_Posts.txt
 

Removing Topic Test:
 

Social_Networking_Posts.txt
 

Export Data Test:

 

Users.txt
 

Friends.txt
 

Posts.txt
 

Import Data Test:

 

Social_Networking_Users.txt
 
Social_Networking_Friends.txt
 
Social_Networking_Posts.txt
 

Resetting Data Test:

 

	This test does not produce any results as resetting the data deletes all of the files from the system and the user’s computer, so there is nothing to show. If you run all of the tests, at the end there will be no files present on your computer, that is thanks to this test.

