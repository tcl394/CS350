# Pair Programming Excercise

## Pair Programming Guide

* Work in Pairs (1 keyboard + 2 brains)
* Switch for every iteration  (micro-story)
* Test - Code - Refactor   (Fail, Pass, Beautify)
* Typer - Talker
* Check your ego at the door —>  Cooperate
* Save both product and test code
* Execute all tests for each micro-story
* Record a log of your time on each test
* Use the main script hack to run your code directly
* Finish with a beautiful module call social_net_crud.py
  
  
## Tests to write

### Build Author CRUD


* CSV file Author ‘Bill, Bill@Here.com’
* Add ‘Sue’ to Author table
* Add list of other names (10 people)
* Read CSV records
* Print Author email
* Change email
* Delete Author


### Build Article CRUD

* CSV file Article ‘Rattlesnakes, I hate snakes’
* Print Article list
* Add Article ‘Kittens, Kittens are Fuzzy’
* Add author_id of 4 to Articles
* Print Articles showing Author names
* Select articles for Author 4
* Lookup ‘4, Kittens’
* Change ‘Kittens’ body to ‘Kittens are cute!’
* Remove Article
* Remove Author


## Next Exercise

Build Author Web Page


	* Run the browser
	* Create file index.html with content “<h1>My Social Network</h1>”
	* Create file authors.html with content “<h1>Authors</h1>”
	* Create HTML template files
	* Insert variables into HTML templates by text substitution  '{{title}}’
	* Insert content into the HTML template   '{{content}}’  ‘<p>Nothing to see here</p>’
	* Build content string as a list  ‘<ul><li>Author 1</li></ul>’
	* Insert content into the HTML template   '{{content}}’ content_string
	* Query the actual authors
	* Add authors to list in page


Build Wall Web Page


	* Create HTML template file wall.html
	* Insert variables into HTML template by text substitution  '{{title}}’ ‘{{posts}}’
	* Build content string as a list  ‘<ul><li>Post 1</li></ul>’
	* Query the actual posts
	* Build content string with actual posts ‘<ul><li>...</li></ul>’
	* Insert list into page


	* Add list of Posts to web page
	* Finish with a beautiful module called social_net_views.py

