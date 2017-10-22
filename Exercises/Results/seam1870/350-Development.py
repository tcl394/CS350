
# coding: utf-8

# # UNC CS350 - Software Engineering
# 
# ## Test Driven Development from scratch
# 
# This exercise will step you through the process of doing test-first development. All work is completed by taking small steps toward a goal.
# 
# The ultimate goal is reached by completing smaller goals which in turn are broken down into smaller tasks.
# 
# ## Development Loop
# 
#     Dev Loop:
#         Select a feature to build
#         Create a test for the desired feature - test must fail
#         Build code (one line) to pass test
#         Refactor - clean up all technical debt

# ## Project Plan
#      
# ### User Stories
# 
#     Register Author
#     Login as Author
#     Create Article
#     Edit Article
#     Delete Article
#     List Article
#     Read Article
# 
#     
# ### Technology
# 
#     Build Utilities
#     Build Page Server
#     Build Page Templates
#     Build User Stories
#   

#   
#     
# ## Design Plan
# 
# ### Architecture
# 
#         Web client - pages for browser
#         Web server - create application pages from objects
#         Application server - business logic and CRUD
#     
# ### Interface
# 
#         Web server
#         
#             Author URLs
#                 author/register.html
#                 login.html
#             Article URLs
#                 create_article
#                 edit_article
#                 delete_article
#             Reader URLs
#                 list_articles
#                 read_article
#                 
#         Application server - business logic and CRUD
#         
#             Author
#                 register_author
#                 login_author
#             Article
#                 create_article
#                 edit_article
#                 delete_article
#             Reader
#                 list_articles
#                 read_article
#     
# ### Data
# 
#         Author Class
#             name
#             email
#             password
#         
#         Article Class
#             author
#             title
#             body
#         
#         Subscriber (later)
#             email
#         
#         Comment (later)
#             article
#             text
#     

# ## Code Plan
#         
#         User Stories
#         
#             Register Author
#             Login as Author
#             Create Article
#             Edit Article
#             Delete Article
#             List Article
#             Read Article
#     
#         Utilities
#         
#             Read/Write File
#             Read/Write CSV
#             Read/Write Object
#             Read/Write JSON
#             Render Page
#             Web Browse

# # Development Tools
# 
# Doing great development is based on having the right tools for the job and knowing how to use them correctly.
# 
# This section of the exercise is about how to setup your development tools for optimum productivity.
# 
# The practices demonstrated here use Python for personal automation, but you can apply these to any programming language and environment.
# 

# ## Tools
# 
# Automatic your most basic tasks
# 
# You should always be able to type a single command to do the most common things done.
# 
# Common Tasks
# 
# * Edit a file
# * Show the source code files
# * Visit the repo
# * Browse to google
# * Commit all code changes
# 
# 
# Each of these tasks should have a command script that allows you to quickly perform that task.  Consider the following code and customize it to your use.
# 

# In[79]:

# Define tool scripts

from os import system
import webbrowser

def edit_file(filename):
    system('notepad.exe '+filename)
    
def browse(page):
    webbrowser.open(page)
    
def github():
    browse('http://github.com/UNC-CS350')
    
def google():
    browse('http://google.com')
    
def explore():
    system('explore.exe c:/users/mark.seaman')
        


# ## Tests
# 
# Every function that we write should be tested.
# 
# A single test function will test all of the tools at once.
# 
# Interactive testing can be used to test the current thing that we are working on at the moment.
# 

# In[84]:

# Test the tools

def test_tools():
    edit_file('xyz.')
    github()
    google()
    python_window()
    
def quick_test():
    
    # Test editing using notepad
    # edit_file('xyz.')
    
    # Test github UNC-CS350 account
    # github()
    
    # Test browsing to google.com
    # google()
    
    # Test the windows explorer
    explore()
    
quick_test()


# ## Files
# 
# Reading and writing files is an important part of almost every program.
# 
# File Types
# 
# * Text Files
# * CSV
# * JSON
# * Objects
# * HTML

# ### Text Files
# 
# Text files are the most basic file type.  Many of the other file types use these functions to save the
# text strings in the actual files.
# 
# * Read text file
# * Write text file
# * Test text file

# In[ ]:

# Read the text from a file
def read_file(filepath):
    return open(filepath).read()[:-1]

# Write the text string to a file
def write_file(filepath, text):
    open(filepath, 'w').write(text+"\n")


# In[95]:

# Test that the file reads and writes the same data
def test_file():
    text = "line1\nline2"
    path = 'test.txt'
    write_file(path, text)
    t = read_file(path)
    # print('text:'+text+'$')
    # print('t:'+t+'$')
    assert(t==text)

# Run test
test_file()


# ### CSV Files
# 
# CSV (Comma-separated files) are a common way to store tables.
# 
# * Read CSV files
# * Write CSV files
# * Test CSV files

# In[127]:

from csv import reader, writer

    
# Read rows and columns from a CSV file
def read_csv(filepath):
    with open(filepath) as f:
        return [row for row in reader(f) if row]

# Write rows and columns to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'wt') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)


# In[129]:

# Test that the file reads and writes the same data
def test_csv():
    path = 'test.csv'
    data = [['a', 'b'], ['c', 'd']]
    write_csv(path, data)
    text = read_csv(path)
    assert(text==data)

# Run test
test_csv()


# ### JSON Files
# 
# JSON files store serialized JavaScript objects.
# 
# * Read JSON file
# * Write JSON file
# * Test JSON file

# In[149]:

from json import loads, dumps

def test_one_object():
    s = {'person': {'name': 'Bob', 'email': 'bob@here.com'}}
    path = 'test.json'
    write_file(path, dumps(s))
    t = loads(read_file(path))
    #print(s)
    assert(s==t)

def test_two_objects():
    s = [{'person': {'name': 'Bob', 'email': 'bob@here.com'}}, 
         {'person': {'name': 'Sue', 'email': 'sue@here.com'}}]
    path = 'test.json'
    write_file(path, dumps(s))
    t = loads(read_file(path))
    #print(s)
    assert(s==t)

test_one_object()
test_two_objects()

