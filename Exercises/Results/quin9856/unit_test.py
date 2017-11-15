

def test_user():
    test_first(set_users()[0].first)
    test_last(set_users()[1].last)
    test_email(set_users()[2].email)

    names = [['tom', 'sawyer', 'saw@email.com'], ['ron', 'dog', 'dog@email.com'], ['kay', 'johnson', 'kay@email.com']]
    add_users(names)

def test_create():
    try:
        user = User("", "", "")
        return user
    except:
        print('object was not created')

class User(object):
    def __init__(self, first, last, email):
        self.first = first
        self.last = last
        self.email = email

#Sets 4 users and puts in a list
def set_users():
    user1 = User('Jon', 'Doe', 'doe@email.com')
    user2 = User('kelly', 'boo', 'boo@email.com')
    user3 = User('jack', 'stacks', 'stacks@email.com')
    user4 = User('don', 'baller', 'baller@email.com')
    userList = [user1, user2, user3, user4]
    return userList

def test_first(userFirst):
    try:
        if userFirst != "":
            pass
    except:
        print("No first name found")

def test_last(userLast):
    try:
        if userLast != "":
            pass
    except:
        print("No first name found")

def test_email(userEmail):
    try:
        if userEmail != "":
            pass
    except:
        print("No first name found")


def add_users(list):
    new_list = []
    for x in list:
        user = User(x[0],x[1],x[2])
        new_list.append(user)
    return new_list

try:
    test_user()
    print("It worked")
except:
    print("something failed")


