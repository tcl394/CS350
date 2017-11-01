def test_user():
    x = test_create()

    set_info(x,'Bob','Smith','BS@Here.com')

    user_prop_test(x)

    abc = set_4_users()

    extract_name(abc,'Peter','Parker')

    list = [['Clark','Kent','CK@Here.com'],['Wally','West','WW@Here.com'],['Li','Land','LL@Here.com']]
    test = add_users_from_list(list)
    
    #test is a list of user objects
    null_test_property(test)

def test_create():
    #x = None
    x = User()
    x.first_name = ""
    x.last_name = ""
    x.email = ""

    assert(x != None)

    return x

def set_info(x,a,b,c):
    x.first_name = a
    x.last_name = b
    x.email = c
    return x


def set_4_users():
    a = []
    x = User()
    x.first_name = 'Bob'
    x.last_name = 'Smith'
    x.email = 'BS@Here.com'
    y = User()
    y.first_name = 'Sue'
    y.last_name = 'Peter'
    y.email = 'SP@Here.com'
    z = User()
    z.first_name = 'Peter'
    z.last_name = 'Parker'
    z.email = 'Spiderman@Here.com'
    c = User
    c.first_name = 'Bruce'
    c.last_name = 'Wayne'
    c.email = 'Bats@Here.com'
    a.append(x)
    a.append(y)
    a.append(z)
    a.append(c)

    return a

def extract_name(abc,first,last):
    for b in range(len(abc)):
        if abc[b]== first and abc[b+1] == last:
            print("Success ", first, last)

def add_users_from_list(xyz):
    new_list = []
    for a in xyz:
        x = User()
        x.first_name = a[0]
        x.last_name = a[1]
        x.email = a[2]
        new_list.append(x)

    return new_list

def null_test_property(xyz):
    for a in xyz:
        if (a.first_name is None or a.last_name is None or a.email is None):
            assert(False)

def user_prop_test(x):
    if(x.first_name == ""):
        assert(False)

    if(x.last_name == ""):
        assert(False)

    if(x.email == ""):
        assert(False)
    
class User:
##  just a different way to do it
##    def __init__(self, first_name, last_name):
##        self.first_name = first_name
##        self.last_name = last_name

    
    def first_name(self, first_name):
        self.first_name = first_name

    def last_name(self, last_name):
        self.last_name = last_name

    def email(self, email):
        self.email = email



if __name__ == '__main__':
    test_user()
