from user import user

def test_user():  
    userOne = test_create()
    test_first(userOne, "Jane")
    test_last(userOne, "Doe")
    test_email(userOne, "JaneDoe@gmail.com")
try:
    test_user()
    print("It worked")
except:
    print("did not work")
    
def test_create():
  try:
        userOne = User("","","")
        return userOne
    except:
        print ('this does not exist')
        
 def test_first(userOne, firstName):
    try:
        userOne.first = firstName
    except:
        print ("first name cannot be added ")
        
def test_last(userOne, lastName):
    try:
        userOne.last = lastName
    except:
        print ("last name cannot be added")
        
def test_email(userOne, email):
    try:
        userOne.email = email
    except:
        print (“Email cannot be added")
 
def test_create():
    try:
        userOne = User("","","")
        return userOne
    except:
        print ('This does not exist')
    
def User;
