from user import User

//Programmed by Javier Perez & Jonathan Mier

def test_create():
    try:
        userOne = User("","","")
        return userOne
    except:
        print ('The object was not created')
    
def test_first(userOne, firstName):
    try:
        userOne.first = firstName
    except:
        print ("The first name could not be added")
  
def test_last(userOne, lastName):
    try:
        userOne.last = lastName
    except:
        print ("The last name could not be added")

def test_email(userOne, email):
    try:
        userOne.email = email
    except:
        print ("The last name could not be added")
    

def test_user():
    userOne = test_create()
    test_first(userOne, "Jon")
    test_last(userOne, "Smith")
    test_email(userOne, "Jon@gmail.com")

try:
    test_user()
    print("Everything worked")
except:
    print("Did not work")
