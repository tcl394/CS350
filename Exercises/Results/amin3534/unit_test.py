def test_user():
    u = test_create()

    set_info(u,'Bob','Smith','BS@Here.com')

    user_prop_test(u)

    xyz = set_4_users()

    extract_name(abc,'Peter','Parker')

    list = [['Clark','Kent','CK@Here.com'],['Wally','West','WW@Here.com'],['Li','Land','LL@Here.com']]
    test = add_users_from_list(list)
    
    #test is a list of user objects
    null_test_property(test)

def test_create():
    u = User()
    u.first_name = ""
    u.last_name = ""
    u.email = ""

    assert(u != None)

    return u

def set_info(u,a,b,c):
    u.first_name = a
    u.last_name = b
    u.email = c
    return u


def set_4_users():
    list = []
    u = User()
    u.first_name = 'Bob'
    u.last_name = 'Smith'
    u.email = 'BS@Here.com'
    u2 = User()
    u2.first_name = 'Sue'
    u2.last_name = 'Peter'
    u2.email = 'SP@Here.com'
    u3 = User()
    u3.first_name = 'Peter'
    u3.last_name = 'Parker'
    u3.email = 'Spiderman@Here.com'
    u4 = User
    u4.first_name = 'Bruce'
    u4.last_name = 'Wayne'
    u4.email = 'Bats@Here.com'
    list.append(u)
    list.append(u2)
    list.append(u3)
    list.append(u4)

    return list

def extract_name(xyz,first,last):
    for b in range(len(abc)):
        if xyz[b]== first and abc[b+1] == last:
            print("Success: ", first, last)

def add_users_from_list(xyz):
    list2 = []
    for a in xyz2:
        u = User()
        u.first_name = a[0]
        u.last_name = a[1]
        u.email = a[2]
        list2.append(u)

    return list2

def null_test_property(xyz2):
    for a in xyz2:
        if (u.first_name is None or u.last_name is None or u.email is None):
            assert(False)

def user_prop_test(u):
    if(u.first_name == " "):
        assert(False)

    if(u.last_name == " "):
        assert(False)

    if(u.email == " "):
        assert(False)
    
    
    def first_name(self, first_name):
        self.first_name = first_name

    def last_name(self, last_name):
        self.last_name = last_name

    def email(self, email):
        self.email = email



if __name__ == '__main__':
    test_user()
