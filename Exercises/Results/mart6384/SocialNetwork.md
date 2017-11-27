Cosme Martinez

Design Plan

November 26, 2017

# Project Plan

## User Registration

-
  - User can sign up
  - Unique identifier

 A user will sign up using a webform with no email address required. He will need a first and last name as well as a password and then he will be asked to create a unique identifier to make him easier to be found.

## Friends List

-
  - Add/Delete friends
  - View Friends

 The user will be able to add and remove friends. He will be able to access a list where all of his friends are.

## Posts

-
  - Add/Remove Posts

 Users can post topics and remove them as well.

# Design Plan

**Architecture**

Computer Client:

- --Web Browser

Web Server:

- --Hypertext Transfer Protocol

E-mail Server:

- --Simple Mail Transfer Protocol

Application Server:

- --Interface

Database:

- --CRUD

**Web Server Interface**

Login:

- --Register
- --Login

Author:

- --Add Post
- --Delete Post

Friends:

- --Add friends
- --Delete friends

**Application Server Interface**

User:

- --Create, read, update, delete

Posts:

- --Create, read, update, delete

Friends:

- --Create, read, update, delete

**Database Schema**

User:

- --Name, password

Post:

- --topic,author

Friends

- --User

##
# Interfaces Detailed Design

**Facebook lite Web Server interface**

Login:

- --Register(name, email, password)
- --Login (name, password)

Author:

- --Add Post (user, body)
- --Edit Post (user, body)
- --Delete Post (user, body)

Reader:

- --List posts (users)

##
# Data

User:

- --Name, email, password

##
# Classes

User:

- --Name, email, password

Post:

- --User, body

Friends

- --Name
