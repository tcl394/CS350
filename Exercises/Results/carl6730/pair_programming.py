
# Teresa Carlson Brittany Archibeque Pair Programming

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

# Solution to CRUD puzzles

#Teresa - time taken: 3 minutes
def create_user_file():
    open('users.csv', 'a').write('aaa')

#Brittany - time taken: 4 minutes
def add_user(name, email):
    users = user_list()
    user.append([name, email])
    write_csv('user.csv', users)
    return users

#Teresa - time taken: 3 minutes
def user_list():
    return read_csv('user.csv')


#Brittany - time taken: 4 minutes
def user_email(name):
    for a in user_list():
        if a[0] == name:
            return a[1]

#Teresa - time taken: 7 minutes
def change_email( oldEmail, newEmail):
    for i, j in email.userlist():
        newEmail = newEmail.replace(i, j)

#Brittany - time taken: 6 minutes
def delete_user(name):
writer = csv.writer(open('corrected.csv'))
    for row in csv.reader('users.csv'):
        if not row[0].startswith(name):
            writer.writerow(row)
            writer.close()


# Tests

# CSV file named 'user.csv' exists
def test_user_file_exists():
    create_user_file()
    assert(exists('user.csv'))


# Test user list
def test_user_file():
    write_file('user.csv', 'Sam, Sam@Here.com')
    for a in user_list():
        print('    '.join(a))


# see if CSV includes Sammy, Sammy@example.com
def test_user_bill():
    write_file('user.csv', 'Sammy, Sammy@example.com')
    users = user_list()
    assert(users[0][0] == 'Bill')


# Add 'Sally' to user table
def test_user_add():
    add_user('Sally', 'sally@example.com')

# Add list of other names (10 people)
def test_user_add_list():
    pass

# Read CSV records
def test_user_list():
    pass

# Print user email
def test_user_email():
    #print(user_email('Bill'))
    assert(user_email('Bill') == 'Bill@Here.com')

# Change Bill's email
def test_change_email():
    assert(user_email('Sue') == 'Sue@Here.com')

# Delete user Sue
def test_delete_user():
    pass


# Tests to write for user CRUD
def test_user_crud():
    test_user_file_exists()
    test_user_bill()
    test_user_add()
    test_user_add_list()
    test_user_list()
    test_user_email()
    test_change_email()
    test_delete_user()
    test_user_file()

def open_CSV():

    open('posts.csv','w').write('Rattlesnakes, I hate snakes')




def print_post():

    ifile  = open('posts.csv', "r", encoding='UTF8')

    read = csv.reader(ifile)

    for row in read :

        print (row)




def add_posts():

    open('posts.csv','a').write('Kittens, Kittens are Fuzzy')




def write_post(text):

    open('posts.csv','a').write(text)




def add_users():

    multiline = os.linesep + 'user_id1' + os.linesep + 'user_id2' + os.linesep + 'user_id3' + os.linesep + 'user_id4'

    open('posts.csv','a').write(multiline)






def print_posts_users():

    ifile  = open('posts.csv', "r", encoding='UTF8')

    read = csv.reader(ifile)

    for row in read :

        print (row)




def remove_post():

    open('posts.csv','a').write('')







def remove_users():

    open('posts.csv','a').write('')







def test_post_crud():




    # * CSV file post 'Rattlesnakes, I hate snakes'

    open_CSV()

    # * Print post list

    print_post()

    # * Add post 'Kittens, Kittens are Fuzzy'

    add_posts()

    write.('Kittens, Kittens are Fuzzy')

    write_post('Kittens, Kittens are Fuzzy')

    # * Add user_id of 4 to posts

    add_users()

    # * Print posts showing user names

    print_posts_users()

    # * Remove post

    remove_post()

    # * Remove user

    remove_users()



    text = "line1\nline2"

    path = 'test.txt'

    write_file(path, text)

    t = read_file(path)

    print('text:'+text+'$')

    print('t:'+t+'$')

    assert(t==text)

    assert(t!=text)

    pass




# Run test

if __name__ == '__main__' :

    test_user_crud()

    test_post_crud()





# Run test
if __name__ == '__main__' :
    test_user_crud()
