# Define tool scripts

import os
import webbrowser


def edit_file(filename):
    print('Edit')
    os.rename('something.txt', 'newname.txt')
    
def browse(page):
    print('Browse '+page)
    webbrowser.open(page)
    
def github():
    print('Github')
    browse('http://github.com/UNC-CS350')
    
def google():
    print('Google')
    browse('http://google.com/search?q=University+Northern+Colorado')
    
def unc():
    print('Canvas')
    browse('http://canvas.unco.edu')
    
def explore(dir):
    print('Explore')
    system('explorer.exe '+dir)
        


# Tests
# 
# Every function that we write should be tested.
# A single test function will test all of the tools at once.
# Interactive testing can be used to test the current thing that we are working on at the moment.
# 

# Test the tools

def test_tools():
    edit_file('tools.py')
    github()
    unc()
    google()
    explore()


# Run code as a script

if __name__ == '__main__' :
    
    # Test editing using notepad
    edit_file('something.txt')
    
    # Test github UNC-CS350 account
    github()
    
    # Test browsing to web pages
    google('kittens')
    # unc()
    
    # Test the windows explorer
     #explore('C:\Users\carl6\Desktop\CS350\CS350-master')
    pass
    

