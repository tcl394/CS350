# Design Plan Exercise - Robert Carver

## Goal

Create a simple design for your social networking application.  Collaborate with others but do not coast on their effort.  You must provide as many ideas as you consume.

Use the World Press Design plan as a model for your plan for the Social Networking app.

Define:
	* Architecture
	* Interfaces
	* Data
/*
Submit results

## Architecture

Architecture - Top-level system design

	* Interfaces
	* Building blocks

Block Diagram

	* Mobile clients
	* Computer clients
	* Web server
	* Application server
	* Database

Architecture Process

	* Partition the system into components
	* Define the interfaces 
	* Create a test plan
	* Manage dependencies

Interfaces
	
	* Each interface, described as a stack of functions
	* Define the signatures
*/

## Insert Social Media Name Here

Architecture

	* Computer Client - Web Browser
	* Mobile Client - Mobile Application
	* Web Server - https, urls to the webpages
	* Email server - SMTP
	* Application server - function interface
	* Database - CRUD for users including:
		- user connections (friends)
		- user unique timelines
		- user posts: images, video, text

Web Server Interface

	* Login
		- signup(name, email, password)
		- login(email, password)

	* User post
		- construct_post(user, title, body, content)
		- edit_post(user, title, body, content)
		- delete_post(user, title)
		- delete_comment(user, title, comment)

	* User timeline
		- get_posts(user) -> list
		- display_post(user, list)
		- interact_post(user, title, action)
		- create_comment(user, title, content)
		- report_post(user1, user2, title, content)

	* User interact
		- view_profile(user1, user2)
		- friend_user(user1, user2)
		- block_user(user1, user2)
		- report_user(user1, user2, content)

Application Server Interface

	* User
		- Create, read, update, delete - CRUD

	* Post
		- Create, read, update, delete - CRUD

	* Timeline
		- Create, read, update, delete - CRUD

Database Schema

	* User 
		- name, email, password, followed content

	* Post
		- user, title, content (video, image, text)

Detailed Interface Design

High level design:
	* Subsystems - partition components
	* Interfaces - each subsystem has an interface
	* Data - what is called where

Web Server Interface (see above, content is the same)

Application Server Interface (methods)

	* User 
		- create_user(name, email, password)
		- read_user(name, password) generates -> user_id
		- list_user() generates the user_list
		- update_user(name, email, password)
		- delete_user(user_id)
		- get_profile(user_id)
		- update_profile(user_id, content) <- profile page items

	* Post
		- create_post(user_id, title, content) generates -> post_id
		- display_post(post_id)
		- list_post(user_id)
		- update_post(user_id, post_id, title, content)
		- delete_poost(user_id, post_id)

	* Timeline
		- get_posts(user_id, user_list) <- user_list full of users in user_id sphere
		- display_timeline(display_post(user_list.getPostID)) <-retrieve post_id, displays posts from user_list
		- action_post(user_id, post_id, action) <- action from web interface SA comment/like/report

Data

ORM
	* Define database structure by specifying classes
	* Progressively generate SQl to match the objects
	* Work is done within the object domain

Data (See DB Schema above)

Classes (See DB Schema for class structure)

Functions for Data
	# Post

	def construct_post(user_id, title, content):
		post.generate.postId -> post_id
		post.object.create(user_id, title, content, post_id)

	def list_post(user_id):
		return post.objects.all()

	def display_post(post_id):
		return post.objects.get(post_id)

	def update_post(user_id, new_title, new_content):
		temp = post.objects.get(user_id,title)
		temp.content = new_content
		temp.title = new_title
		temp.save()

	def delete_post(user_id, post_id):
		post.objects.delete(user_id, post_id)

	def list_post(user_id):
		return user_id.contentList