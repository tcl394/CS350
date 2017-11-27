from os.path import exists
from os import remove
from csv import reader, writer


# Write rows and columns to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'w') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)

#append to an existing file
def add_row_csv(filepath, data):
    text = read_csv(filepath)
    text += data
    write_csv(filepath, text)

# Read rows and columns from a CSV file
def read_csv(filepath):
    with open(filepath, 'r') as f:
        return [row for row in reader(f) if row]

#exports all the files (users and posts) to a copy
def export_csvs():
    people = read_csv('people.csv')
    write_csv('people_export.csv', people)
    peoplecopy = read_csv('people_export.csv')
    assert(people == peoplecopy)
    posts = read_csv('posts.csv')
    write_csv('posts_export.csv', posts)

#imports the files (users and post) into the system
def import_csvs():
    people = read_csv('people_export.csv')
    write_csv('people.csv', people)
    #user_counter = len(people)/4
    posts = read_csv('posts_export.csv')
    write_csv('posts.csv', posts)

#reset all files (users and posts) to empty
def reset_all_files():
    export_csvs()
    write_csv('people.csv', '')
    write_csv('posts.csv', '')

#list all users in system
def list_people():
    people = read_csv('people.csv')
    for a in people:
        print (a)
        
#list all posts in system
def list_posts():
    posts = read_csv('posts.csv')
    for a in posts:
        print (a)

#create necesary files
def create_files():
    open('people.csv','w')
    open('posts.csv', 'w')

#add a new user
def add_person(fname,lname,email,friends): 
    people = read_csv('people.csv')
    user_counter = int(len(people)/5)
    user_counter += 1
    while user_counter in people:
        user_counter += 1
    if user_counter == '01':
        user_counter = '1'
    info = [[user_counter],[fname],[lname],[email],friends]
    add_row_csv('people.csv', info)

#delete a user
def delete_person(userid):
    people = read_csv('people.csv')
    i=0
    while userid != people[i]:
       i += 5
    del people[i:i+5]
    write_csv('people.csv',people)
    delete_users_posts(userid)

#add a post
def add_post(userid,topic,contents):
    posts = read_csv('posts.csv')
    post_counter = int(len(posts)/4)
    post_counter += int(1)
    while post_counter in posts:
        post_counter += 1
    postid = post_counter
    info = [[userid],[postid],[topic],[contents]]    
    add_row_csv('posts.csv',info)

#change a users email
def update_email(userid, newemail):
    people = read_csv('people.csv')
    i=0
    while userid != people[i]:
       i += 5
    people[i+3] = [newemail]
    write_csv('people.csv',people)

#delete a post
def delete_post(postid):
    posts = read_csv('posts.csv')
    i = 1
    while postid != posts[i]:
        i+=4
    del posts[i-1:i+3]
    write_csv('posts.csv',posts)

#removes all of a users posts
def delete_users_posts(userid):
    posts = read_csv('posts.csv')
    i = 0
    while i<len(posts)-4:
        if userid != posts[i]:
            i+=4
        if i<len(posts):
            if userid == posts[i]:
                delete_post(posts[i+1])
                posts = read_csv('posts.csv')
                
    

#edit the body of a post
def edit_post_contents(postid,contents):
    posts = read_csv('posts.csv')
    i = 1
    while postid != posts[i]:
        i+4
    posts[i+2] = contents
    write_csv('posts.csv',posts)

#edit the title of a post
def edit_post_title(postid,contents):
    posts = read_csv('posts.csv')
    i = 1
    while postid != posts[i]:
        i+4
    posts[i+1] = contents
    write_csv('posts.csv',posts)

#add a friend to an existing user
def add_friend(userid,friendid):
    people = read_csv('people.csv')
    i = 0
    while userid != people[i] and i<len(people)-5:
        i+=5
    if userid == people[i]:
        people[i+4].append(friendid)
        write_csv('people.csv',people)

#lists the posts a user has posted
def list_user_posts(userid):
    posts = read_csv('posts.csv')
    i = 0
    stati = []
    test = []
    test += [str(userid)]
    while i<len(posts):
        if posts[i] == test:
            stati += [str(posts[i+2][0]) + ': ' + str(posts[i+3][0])]
        i += 4
    return stati

# remove a friend
def delete_friend(userid,friendid):
    people = read_csv('people.csv')
    i=0
    while userid != people[i] and i<len(people):
        i += 5
    friends = []
    friends += people[i+4]
    j = 0
    while j < len(friends):
        if friends[j] == friendid:
            del friends[j]
            j -=1
        j +=1
    people[i+4] = friends
    write_csv('people.csv',people)

#display all posts from friends
def show_friend_posts(userid):
    people = read_csv('people.csv')
    posts = ''
    i = 0
    while userid != people[i] and i<len(people):
        i +=5
    friends = []
    friends += people[i+4]
    for j in friends:
        name = get_person_name([j]) + ': '
        posts += name + str(list_user_posts(j)) +'\n'
    return posts

# returns the name of a user based on their userid
def get_person_name(userid):
    people = read_csv('people.csv')
    i = 0
    name = ''
    while userid != people[i] and i<len(people):
        i +=5
    if userid == people[i]:
        name += str(people[i+1][0]) + ' '
        name += str(people[i+2][0])
    return name

#returns the names of a users friends
def list_friends(userid):
    people = read_csv('people.csv')
    names = []
    i=0
    while userid != people[i] and i<len(people):
        i +=5
    friends = []
    friends += people[i+4]
    for j in friends:
        names += [get_person_name([j])]
    return (names)

# fills files with data that you can run code against
def generate_data():
    reset_all_files()
    add_person('Nik','Jones','jone2032@bears.unco.edu',['2','5','4'])
    add_person('Bobby','Herms','herm8464@bears.unco.edu',['1','4'])
    add_person('Sid','Campe','camp3060@bears.unco.edu',['2'])
    add_person('Jake','Loki','loki1234@bears.unco.edu',['1','2','4'])
    add_person('David','Voss','voss0420@bears.unco.edu',['1','2','3','4'])
    add_post(1,'Coding','Coding is really cool!')
    add_post(1,'Hobbies','I like to hike and kayak!')
    add_post(2,'Gaming','I just love Destiny2!')
    add_post(3,'Dishes','Where are all these dishes coming from?!')
    add_post(4,'Working','Ho Ho, Ho Ho its off to work I go!')
    add_post(5,'Football','Man the Broncos need to pick it up this year!')
    export_csvs()
    
if __name__ == '__main__':
    generate_data()
    print(show_friend_posts(['1']))
    print(show_friend_posts(['5']))
    print(list_friends(['5']))
    delete_friend(['5'],'1')
    print(show_friend_posts(['5']))
    print(list_friends(['5']))
    delete_users_posts(['1'])
   
    
