from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file


def post_list():
    return read_csv('post.csv')


def display_post_file():
    post = post_list()
    print('Posts on database: ')
    for p in post:
        print('PostID: ' + p[0], ', ' , p[1], ', ' ,p[2] , ', ',p[3])

def new_post():
    post = post_list()
    print('Add a new post!')      
    postID = input('Enter Post ID: ')
    postTitle = input('Enter Post Title: ')
    postBody = input('Enter Text: ')
    userID = input('Enter User ID: ')                
    if (postID != '')and(postTitle!='')and(postBody!='')and(userID!=''):
        post.append([postID,postTitle,postBody,userID])
        write_csv('post.csv',post)
        print('New Post Added Successfully!'+'\n')
    else:pass

            
def sub_add_post_from_user(postID,postTitle,postText,userID):
    post = post_list()
    post.append([postID,postTitle,postText,userID])
    write_csv('post.csv',post)
    return post

def add_post_from_user():
    post = post_list()
    print('Add a post from other user`s post!')
    userID = input('Enter your userID: ')
    postID = input('Enter Post ID: ')
    otheruserID = input('Enter other user ID: ')
    for p in post:
        if p[0] == postID and p[3] == otheruserID:
            sub_add_post_from_user(p[0],p[1],p[2],userID)
        else:pass
                
def delete_post():
    post = post_list()
    print('Delete a post!')
    postID = input('Enter Post ID: ')
    for p in post:
        if p[0] == postID:
            post.remove(p)
    write_csv('post.csv', post)
            
            
    
