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

