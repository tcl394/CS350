# Academic Social Media Design Plan

## Architecture

Browser - Web Server
Application Server
Database

## Interfaces

### Web Server Interface

- Login
   - Register (userId, username, email, password, birthDate)
   - Login (username, password) or (email, password)

- User
   - create_post (postId, username, body)
   - delete_post (postId)
   - flag_post (postId, userId)
   - obtain_feed (userId)

- Moderator
   - view_flagged (moderatorId)
   - delete_post (postId, moderatorId)
   - delete_user (userId, moderatorId)

### Application Server Interface

- CRUD - create, read, update, delete *for the following objects*:
   - User
   - Post
   - Moderator

### Database Schema

- User
   - userId
   - username
   - email
   - password
   - birthDate
   - postList
   - friendList

- Post
   - user
   - body

- Moderator
   - moderatorId
   - username
   - password
