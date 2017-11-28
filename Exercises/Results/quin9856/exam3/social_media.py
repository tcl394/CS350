class Person:
    def __init__(self, username, password):
        self.username = username
        self.password = password
        self.friends = []
        self.post = post()


    def addFriend(self, friend):
        self.friends.append(friend)

    def printFriends(self):
        for friend in self.friends:
            print(friend.username)

    def removeFriend(self, friend):
        for x in self.friends:
            if x.username == friend:
                self.friends.remove(x)

    def friendPosts(self):
        for x in self.friends:
            print(x.username, ": ", x.post.viewPosts(), "\n")



class post:
    def __init__(self):
        self.posts = []

    def makePost(self, text):
        self.posts.append(text)

    def delPost(self, delete, activeUser):
        activeUser.post.posts.remove(activeUser.post.posts[delete])

    def viewPosts(self):
        for post in self.posts:
            return self.posts.index(post), post

def exportPosts(user):
    return user.post.posts

def exportFriends(user):
    return user.friends

def clearData(user):
    user.post.posts.clear()
    user.friends.clear()



def checkExisting(objList, pword):
    if any(x.password == pword for x in objList):
        return True

def login(objList, pword):
    for obj in objList:
        if obj.password == pword:
            activeIndex = objList.index(obj)
            active = objList[activeIndex]
    return active