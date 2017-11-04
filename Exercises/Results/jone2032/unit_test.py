# unit_test.py

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

def test_user(user):
    try:
        test_name(user)
        try:
            test_email(user)
            print(user.name() + " was successully checked!")
        except AssertionError:
            print("User: " + user.name() +" doesn't have an email!")
    except AssertionError:
        print("User doesn't have a name!")
    
    
def test_create():
    user = create_user('Nik','Jones','jone2032@bears.unco.edu')
    #print(user.firstname)
    #return user
    #assert(user.email in locals())
    assert('user' in locals()) ## <<< is this actually checking the existance of object user or a string "user"?
    #assert(user not in locals())  

def test_create_multiple():
    user1 = create_user('Nik','Jones','jone2032@bears.unco.edu')
    user2 = create_user('Bobby','Hermsmeyer','herm1004@bears.unco.edu')
    user3 = create_user('Jake','Loki','loki7156@bears.unco.edu')
    user4 = create_user('David','Voss','voss5834@bears.unco.edu')
    user5 = create_user('Sid','Campe','camp6969@bears.unco.edu')
    users = [['Nik','Jones','jone2032@bears.unco.edu'],['Bobby','Hermsmeyer','herm1004@bears.unco.edu'],['Jake','Loki','loki7156@bears.unco.edu'],['David','Voss','voss5834@bears.unco.edu'],['Sid','Campe','camp6969@bears.unco.edu'],['','',''],['a','b','']]
    write_csv('users.csv',users)

class User():
    firstname = ""
    lastname = ""
    email = ""

    def __init__(self, fname, lname, email):
        self.firstname = fname
        self.lastname = lname
        self.email = email
        
    def name(self):
        name = self.firstname + ' ' + self.lastname
        assert(name != " ")
        return name

def create_user(fname, lname, email):
    user = User(fname,lname,email)
    return user

def test_name(user):
    test = user.name()
    answer = user.firstname + ' ' + user.lastname
    assert(test == answer)
    #assert(test != answer)

def test_email(user):
    answer = user.email
    assert(answer != "")
    #assert(answer == "")
    

def test_all_users_from(path):
    #if(path.exists):
        users = read_csv(path)
        for i in users:
            fname = i[0]
            lname = i[1]
            email = i[2]
            newUser = create_user(fname,lname,email)
            test_user(newUser)
  

if __name__ == "__main__":
    test_create()
    test_create_multiple()
    test_all_users_from('users.csv')

    ## confusion on the try catch
    ## are we removing the asserts and replacing with returns of false?
    ## not entirely sure how this should look

