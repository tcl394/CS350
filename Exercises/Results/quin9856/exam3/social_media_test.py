import social_media, pickle, sys

userList = []

def userMenu(activeUser):
    running = True
    while running:
        action = input("What would you like to do: \n"
                "1. View Friend Posts \n"
                "2. Your Post Options \n"
                "3. Make Post \n"
                "4. View Friends \n"
                "5. Add Friends \n"
                "6. Remove Friend \n"
                "7. Log out \n")

        if action == "1":
            activeUser.friendPosts()

        if action == "2":
            postOption = input("What would you like to do: \n"
                               "1. View your posts \n"
                               "2. Delete a post \n"
                               "3. Cancel \n")
            if postOption == "1":
                print(activeUser.post.viewPosts())
            if postOption == "2":
                if activeUser.post.posts:
                    print(activeUser.post.viewPosts())
                    delete = int(input("Enter the number of the post you want to delete: "))
                    activeUser.post.delPost(delete, activeUser)
                else:
                    print("No posts")

        if action == "3":
            postText = input("What do you want your post to say: \n")
            activeUser.post.makePost(postText)

        if action == "4":
            activeUser.printFriends()

        if action == "5":
            add = input("Enter the username of the friend you want to add: ")
            for obj in userList:
                if obj.username == add:
                    activeFriend = obj
                    activeUser.addFriend(activeFriend)
                    activeFriend.addFriend(activeUser)

        if action == "6":
            friend = input("Enter the username of the friend you want to remove: ")
            activeUser.removeFriend(friend)

        if action == "7":
            mainMenu()

def sysMenu():

    sysAction = input("What would you like to do: \n"
                      "1. Reset all data \n"
                      "2. Export \n"
                      "3. Import \n")


    if sysAction == "1":
        for user in userList:
            social_media.clearData(user)
            userList.remove(user)

    if sysAction == "2":
        pickle.dump(userList, open("users.pickle", "wb"))

    if sysAction == "3":
        for obj in pickle.load(open("users.pickle", "rb")):
            userList.append(obj)

def mainMenu():
    running = True
    while running:
        initAction = input("What would you like to do: \n"
            "1. Create new user \n"
            "2. Log In \n"
            "3. System Options \n"
            "4. Quit")

        if initAction == "1":
            uname = input("Enter username:")
            pword = input("Enter password:")
            userList.append(social_media.Person(uname, pword))

        if initAction == "2":
            passwrd = input("Enter password:")
            if social_media.checkExisting(userList, passwrd):
                active = social_media.login(userList, passwrd)
                userMenu(active)

        if initAction == "3":
            sysMenu()

        if initAction == "4":
            sys.exit()
            running = False


mainMenu()