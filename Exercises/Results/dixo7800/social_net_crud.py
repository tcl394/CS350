#social_net_crud.py
#Chris Newby & Shawn Dixon
#Pair Programming Exercise
#10/27/17
#CS350

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

#============================================================================
#Author Functions

def create_author_file():
    open('author.csv', 'w').write('Start')


def author_file_exists_test():
    #Passing Test
    create_author_file()
    #Failing Test
    assert(exists('author.csv'))

    
def author_exists(name):
    #Failing Test
    #return read_csv('author.csv')
    
    #Passing Test
    authors = read_csv('author.csv')
    #print (authors)
    z = ""

    for a in authors:
        for b in a:
            if b == name:
                z = name + " is in the list!"

    if z == "":
        z = "Name not in list"

    print(z)
    return z    

def add_author(name, email):
    authors = author_list()
    authors.append([name, email])
    write_csv('author.csv', authors)
    return authors

def print_author_email():
    authors = read_csv('author.csv')
    z = ""
    for a in authors:
        for b in a:
            if '@' in b:
                z = z + b + ', '

    print(z)
    return z

def change_email(old_email, new_email):
    authors = read_csv('author.csv')
    for a in authors:
        for b in range(len(a)):
            if a[b] == old_email:
                a[b] = new_email

    print(authors)
    write_csv('author.csv', authors)
    return(authors)

def author_list():
    return read_csv('author.csv')

def delete_author(name):
    authors = read_csv('author.csv')
    for a in authors:
        for b in range(len(a)):
            if a[b] == name:
                a[b] = ""
                a[b+1] = ""

                

    print (authors)
    write_csv('author.csv', authors)
    return authors

def add_10_authors():
    add_author('Marty', 'Marty@Here.com')
    add_author('Jim','Jim@Here.com')
    add_author('Morty', 'Morty@C137')
    add_author('Rick','Rick@C137')
    add_author('Chris', 'Chris@gmail.com')
    add_author('Steve', 'steve@here.com')
    add_author('Jake', 'Jake@here.com')
    add_author('Shawn', 'Shawn@here.com')
    add_author('Batman', 'Batman@batcave')

def display_author_list():
    authors = read_csv('author.csv')
    z = ""
    for a in authors:
        for b in a:
            if '@' not in b:
                z = z + b + ', '

    print(z)
    return z


#============================================================================
#Author Testing Functions

def author_crud_test():
    author_file_exists_test()
    add_10_authors()
    print_author_email()
    change_email('Shawn@here.com', 'SD005@here.com')
    author_exists('Rick')
    display_author_list()
    delete_author('Marty')

#============================================================================
#Article Functions
def create_article_file():
    open('article.csv', 'w').write('Start')

def article_exists():
    #Passing Test
    create_article_file()
    #Failing Test
    assert(exists('article.csv'))

def article_list():
    return read_csv('article.csv')

def add_article(name,title,body):
    articles = article_list()
    articles.append([name, title, body])
    write_csv('article.csv', articles)
    return articles

def select_articles():
    articles = read_csv('article.csv')
    arts = ""
    for a in articles:
        for b in range(len(a)):
            if b == 1:
                arts = arts + a[b] + ", "
            

    print("Available Articles: " + arts)
    return arts

def lookup(title):
    articles = read_csv('article.csv')
    for a in articles:
        for b in range(len(a)):
            if b == 1 and a[b] == title:
                print("Title: " +a[b] +" \nBody: " + a[b+1])

    return articles

def change_body(title, new_body):
    articles = read_csv('article.csv')
    for a in articles:
        for b in range(len(a)):
            if b ==1 and a[b] == title:
                a[b+1] = new_body

    write_csv('article.csv', articles)
    print(articles)
    return articles
#============================================================================
#Article Testing Functions

def article_crud_test():
    
    article_exists()
    article_list()
    add_article('Bill','Beginning','Here is the start of my article. I hope you all like it.')
    add_article('Sue','Rattlesnakes, I hate snakes','Snake are the worst!')
    select_articles()
    lookup('Rattlesnakes, I hate snakes')
    change_body('Beginning', "A new beginning to the world is here. All must change.")

#============================================================================
#Non Author/Article Functions

def add_10_to_list():
    #Failing Test
    
    
    #Passing Test
    for i in range(10):
        print('marty'+str(i)+','+'marty'+str(i)+'@here.com')
        #add_author('marty'+str(i)+','+'marty'+str(i)+'@here.com') 
    #pass


#============================================================================
#Non Author/Article Testing Functions

def non_auth_art_crud_test():
    add_10_to_list()

#============================================================================

def all_crud_tests():
    author_crud_test()
    article_crud_test()
    #non_auth_art_crud_test()
    
#============================================================================
#Master Test

if __name__ == '__main__' :
    all_crud_tests()

