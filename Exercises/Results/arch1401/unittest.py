



from user import User





def test_create():

    try:

        userOne = User("","","")

        return userOne

    except:

        print ('This does not exist')



def test_first(userOne, firstName):

    try:

        userOne.first = firstName

    except:

        print ("First name cannot be added ")



def test_last(userOne, lastName):

    try:

        userOne.last = lastName

    except:

        print ("Last name cannot be added")




def test_email(userOne, email):

    try:

        userOne.email = email

    except:

        print (“Email cannot be added")






def test_user():

    userOne = test_create()

    test_first(userOne, "Sue")

    test_last(userOne, "Miller")

    test_email(userOne, "Sue@Here.com")




try:

    test_user()

    print("It works!")

except:

    print("Does not Work!")
