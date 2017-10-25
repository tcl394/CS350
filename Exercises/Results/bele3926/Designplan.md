**Design plan for Facebook App**.

Architecture

- Computer client: Web browser
- Web server: http, urls to web pages
- Application server:  function interface
- Database: CRUD for user, post, social

Web server interface

- Login

- Register (first\_name, last\_name, email, password)
- Login (email, password)

- Post

- Post\_picture (user, caption, picture)
- Edit\_picture\_caption (use, caption, picture)
- Delete\_picture (user, picture)

- Social

- Send\_friend\_request (user, friend)
- Accept\_request (user, friend)
- Delete\_friend (user, friend)
- Send\_message (use, friend, message)

Application Server Interface

- User

- CRUS - Create, Read, Edit, Delete

- Post

- CRUS - Create, Read, Edit, Delete

- Social

- CRUS - Create, Read, Edit, Delete

Database Schema

- User

- Fname, lname, email, password

- Post

- User, caption, picture

- Social

- User, Friend\_fname, friend\_lname, friend\_email





Facebook Server Interface (Function)

- User

- register\_user(First\_name, last\_name, email, password)
- Log\_in(email, password)

- Post

- create\_post (user\_id, caption, picture)
- see\_post(pic\_id)
- update\_post(user, caption, picture)
- delete\_post(user, picture)

- social

- send\_friend\_request(user, name)
- accept\_friend\_request(user, name)
- chat\_with\_friend(user, message)
- delete\_friend(user)

Data

Object Relational Mapping (Rom)

Facebook data

- User

- First\_name, last\_name, email, password

- Post

- User, caption, picture

- Social

- User, friend, message

Facebook classes

- User

- First\_name, last\_name, email, password

- Post

- User, caption, picture

- Social

- User, friend, message

Facebook function for data

- Registration

def register\_user(First\_name, last\_name, email, password)

      User.object.register(First\_name, last\_name, email, password)

def Log\_in(email, password)

       User.object.login(email, password)

- Post

        def create\_post (user, caption, picture)

                 post.object.create (user, caption, picture)

        def see\_post(pic\_id)

              return post.object.get(pk= pic\_id)

        def update\_post(user, caption, picture)

               x=post.object.get(user=user, caption=caption)

               x.picture=picture

               x.save()

          def delete\_post(user, picture)

                 post.object.delete(user=user, picture=picture)

- Social

             def  send\_friend\_request(user, name)

                     friend\_request.object\_send(user, name)

               def accept\_friend\_request(user, name)

                      friend\_request.object.accept(user, name)

              def chat\_with\_friend(user, message)

                     chat.object.send(user, message)

              def delete\_friend(user)

                     delete.object.friend(user)