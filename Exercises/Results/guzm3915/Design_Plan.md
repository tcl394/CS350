## Facebook for Old People

Architecture - Top-level system design

    * Interface Browsers (Chrome, Internet Explorer, Edge, Firefox, Safari)
    * Phone Interface (Possible App when browser interface and database is complete)
    * ASP.Net architecture 
    * Database System for holding user info

Block Diagram

[![N|Solid](https://cdn.discordapp.com/attachments/324707524651646976/372132182048899082/image.png)](ohttps://cdn.discordapp.com/attachments/324707524651646976/372132182048899082/image.png)

    * Mobile clients (iPhones, Androids, ect)
    * Computer clients (Browser based)
    * Web server 
    * Application server
    * Database

Architecture Process (What kinds of things we are going to need)

    * Computer clients (Web browsers on Windows and Macs, or specific browsers)
    * Web server (https, urls)
    * Application server
    * Database (CRUD for User, Article, Subscriber)


Web Interfaces

    * Login
	    * registeration (name, email, password, possible other fields)
	    * login and user information storage of interface data (name, password)
    * Post Data (Primarily user based. Do they post? Can they edit?)
	    * add_post (user, title, body)
	    * edit_post (user, title, body)
	    * delete_post (user, title)
	    * get_post (title subject, information, other posts [Feeling, location, etc])
	    * list_posts (user, privacy settings, etc.)

Application Server Interface

    * User
    	* CRUD - create, read, update, delete
    * Posts
	    * CRUD - create, read, update, delete

