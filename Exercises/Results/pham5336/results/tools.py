# Define tool scripts

from os import system
import webbrowser


def edit_file(filename):
    print('Edit file: ' + filename)  
    system('"notepad.exe" '+filename)
    
#def browse(page):
 #   print('Browse to: '+page)
  #  webbrowser.open('http://' +page)

def browse(page):
    print('Browse to: '+page)
    webbrowser.open(page)
    
def github(githubAcc):
    print('Github CS350 account')
    browse('http://github.com/' +githubAcc)
    
def google(webPage):
    print('Open Google')
    browse('http://google.com/search?q='+webPage)
    
def unc():
    print('Open UNC website')
    browse('www.unco.edu')
    
def explore(dir):
    print('Open Explore with a specific directory')
    system('explorer.exe '+dir)
        


# Tests
# 
# Every function that we write should be tested.
# A single test function will test all of the tools at once.
# Interactive testing can be used to test the current thing that we are working on at the moment.
# 

# Test the tools

def test_tools():
    edit_file('tools.py')                   #'tools.py'
    browse('iexplore')                      #'iexplore' / 'chrome'
    github('UNC-CS350')                     #'UNC-CS350'
    unc()                                   # unc()
    google('software engineering')          #'software engineering'
    explore('C:\\Users\Public\Videos')      #'C:\\Users\Public\Videos'


# Run code as a script

#if __name__ == '__main__' :
    
    # Test editing using notepad  
    # edit_file('tools.py')
    
    # Test github UNC-CS350 account
    # github('UNC-CS350')
    
    # Test browsing to web pages
    # google('http://cnn.com')

    # Test browsing to UNC webpage
    # unc()
    
    # Test the windows explorer
    # explore('C:\\Users\Public\Videos')
    
    # Test browser
    # browse('https://www.accuweather.com')

