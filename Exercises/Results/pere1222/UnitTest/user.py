class User(object):


    def __init__(self, first,last,email):
        self.first = first
        self.last = last
        self.email = email
        
    def name(self):
        return first + " " + last
