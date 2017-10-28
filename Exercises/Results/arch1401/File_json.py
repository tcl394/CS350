# File_json.py

from json import loads, dumps
from file_text import read_file, write_file

# Read python dictionaries from a JSON file
def read_json(path):
    s = read_file(path)
    return loads(s)


# Write python objects into a JSON file
def write_json(path, data):
    s = dumps(data)
    write_file(path, s)


# Test writing one object to the file    
def test_one_object():
    s = {'person': {'name': 'Bob', 'email': 'bob@here.com'}}
    path = 'test.json'
    write_json(path, s)
    t = read_json(path)
    #print(s)
    assert(s==t)
    #assert(s!=t)


# Test writing two objects to the file  
def test_two_objects():
    s = [{'person': {'name': 'Bob', 'email': 'bob@here.com'}}, 
         {'person': {'name': 'Sue', 'email': 'sue@here.com'}}]
    path = 'test.json'
    write_json(path, s)
    t = read_json(path)
    #print(s)
    assert(s==t)
    #assert(s!=t)


# Run code as a script

if __name__ == '__main__' :
    test_one_object()
    test_two_objects()
