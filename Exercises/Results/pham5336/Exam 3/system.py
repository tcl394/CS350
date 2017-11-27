#system.py


from os.path import exists
from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file
from post import post_list
from login import person_list
from friend import friend_list



def reset_data():
    open('person.csv','w').close()
    open('post.csv','w').close()
    open('friend.csv','w').close()
    

def export_to_txt():
    person = person_list()
    post = post_list()
    friend = friend_list()
    write_csv('personExport.txt',person)
    write_csv('postExport.txt',post)
    write_csv('friendExport.txt',friend)
    

def import_to_csv():
    person = read_csv('personImport.txt')
    post = read_csv('postImport.txt')
    friend = read_csv('friendImport.txt')
    write_csv('person.csv',person)
    write_csv('post.csv',post)
    write_csv('friend.csv',friend)
