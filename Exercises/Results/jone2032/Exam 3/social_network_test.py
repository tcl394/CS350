from social_network import *


def test_read_write_csv():
    text = [['name']]
    write_csv('test_csv.csv.',text)
    answer = read_csv('test_csv.csv')
    assert(answer == text)

def test_add_row_csv():
    text = [['and things']]
    write_csv('test_csv.csv', [['stuff']])
    text1 = read_csv('test_csv.csv')
    add_row_csv('test_csv.csv', text)
    text2 = read_csv('test_csv.csv')
    text3 = text1 + text
    assert(text2 == text3)

def test_create_files():
    create_files()
    assert(exists('people.csv'))
    assert(exists('posts.csv'))

def test_add_person():
    add_person('Nik','Jones','jone2032@bears.unco.edu',['none'])
    text = read_csv('people.csv')
    assert('Nik' in text[-4])
    delete_person(text[-5])

def test_add_post():
    add_post(1,'Coding', 'Coding is so cool!')
    text = read_csv('posts.csv')
    assert('Coding' in text[-2])
    delete_post(text[-3])

def test_delete_person():
    add_person('Mike','Jones','mj@mj.com',['too many'])
    people = read_csv('people.csv')
    userid = people[-5]
    delete_person(userid)
    people = read_csv('people.csv')
    assert('mj@mj.com' not in people)

def test_delete_post():
    #add_post(1,'code','code stuff')
    add_post(2,'stuff','things')
    posts = read_csv('posts.csv')
    postid = posts[-3]
    delete_post(postid)
    posts = read_csv('posts.csv')
    assert('things' not in posts)

def test_edit_post():
    add_post(2,'stuff','things')
    posts=read_csv('posts.csv')
    postid = posts[-3]
    edit_post_contents(postid, ['new text'])
    edit_post_title(postid, ['new title'])
    posts = read_csv('posts.csv')
    assert(['things'] not in posts)
    assert(['new text'] in posts)
    assert(['stuff'] not in posts)
    assert(['new title'] in posts)
    delete_post(postid)

def test_add_friend():
    add_person('test','user','test@test.com','1')
    people = read_csv('people.csv')
    userid = people[-5]
    add_friend(userid,5)
    people = read_csv('people.csv')
    assert( '5' in people[-1])
    delete_person(userid)

def test_list_user_post():
    add_person('test','user','test@test.com','1')
    people = read_csv('people.csv')
    userid = people[-5][0]
    add_post(userid,'Test Topic','contents')
    posts = read_csv('posts.csv')
    text = list_user_posts(userid)
    assert(text == ["Test Topic: contents"])
    delete_person([userid])
    delete_post(posts[1])

def test_delete_friend():
    add_person('test','user','test@test.com',['2','1'])
    people = read_csv('people.csv')
    friendid = [people[-5][0]]
    add_person('test2','user2','test2@test.com',friendid)
    people = read_csv('people.csv')
    userid = people[-5][0]
    assert(friendid == people[-1])
    delete_friend([userid],[friendid])
    people = read_csv('people.csv')
    assert(friendid not in people[-1])
    delete_person([userid])
    delete_person(friendid)

def test_get_person_name():
    add_person('test','user','test@test.com',['2','1'])
    people = read_csv('people.csv')
    userid = people[-5]
    name = get_person_name(userid)
    assert(name == 'test user')

def test_list_friends():
    add_person('test','user','test@test.com',['2','1'])
    people = read_csv('people.csv')
    friendid = [people[-5][0]]
    add_person('test2','user2','test2@test.com',friendid)
    people = read_csv('people.csv')
    userid = people[-5][0]
    names = list_friends([userid])
    assert('test user' in names)
    delete_person([userid])
    delete_person(friendid)

def test_update_email():
    add_person('test','user','test@test.com','1')
    people = read_csv('people.csv')
    userid = people[-5]
    update_email(userid, 'newemail@test.com')
    people = read_csv('people.csv')
    assert('newemail@test.com' == people[-2][0])
    delete_person(userid)


#----------------------------------------#

def test_person():
    test_add_person()
    test_delete_person()
    test_add_friend()
    test_delete_friend()
    test_get_person_name()
    test_list_friends()
    test_update_email()


def test_post():
    test_add_post()
    test_delete_post()
    test_edit_post()
    test_list_user_post()

def test_csvs():
    test_create_files()
    test_read_write_csv()
    test_add_row_csv()
    list_people()
    

def test_systems():
    write_csv('people.csv',[['01'],['Nik'], ['Jones'],['testemail@test.com'],['would be friends']])
    write_csv('posts.csv',[['01'],['01'],['Title'],['Contents']])
    people1 = read_csv('people.csv')
    posts1 = read_csv('posts.csv')
    export_csvs()
    reset_all_files()
    import_csvs()
    people2 = read_csv('people.csv')
    posts2 = read_csv('posts.csv')
    assert(people1 == people2)
    assert(posts1 == posts2)

#-------------------------------------------#
if __name__ == '__main__':
    test_csvs()
    test_person()
    test_post()
    test_systems()
    print('Tests complete')
    
