def test_user():
	x = test_create()

def test_create():
  x = none
  x = user()
  x.firstName = ""
  x.lastName = ""
  x.email = ""
  
  assert(x != none)
  return x

def set_info(x,first,last,email):
  x.first_name = first
  x.last_name = last
  x.email = email
  return x


def set_users():
  a = []
  one = user()
  one.firstName = 'Bob'
  one.lastName = 'Smith'
  one.email = 'BS@Here.com'
 
  two = user()
  two.firstName = 'Mary'
  two.lastName = 'Jane'
  two.email = 'MJ@Aye.com
	
  three.firstName = 'Fish'
  three.lastName = 'Food'
  three.email = 'FishFood@Email.com
	
  four.firstName = 'Bar'
  four.lastName = 'Bell'
  four.email = 'LiftHeavy@gym.com
    
  a.append(one)
  a.append(two)
  a.append(three)
  a.append(four)

  return a
  
def add_users_from_list(xyz):
    new_list = []
    for a in xyz:
        x = User()
        x.first_name = a[0]
        x.last_name = a[1]
        x.email = a[2]
        new_list.append(x)

    return new_list	
  
def test_first(one, firstName):
    try:
        one.first = firstName
    except:
        print ("No First Name")
  
def test_last(one, lastName):
    try:
        one.last = lastName
    except:
        print ("No Last Name")

def test_email(one, email):
    try:
        one.email = email
    except:
        print ("No Email")
