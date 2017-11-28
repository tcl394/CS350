from os.path import exists
from files import read_csv, read_file, write_csv, write_file

# User CRUD base functions
def create_user_file():
	open('users_profile.csv', 'w').write('xxx')
	
def add_user():
	users=users_display()
	users.append([name, email]);
	write_csv('users_profile.csv', users)
	return users
	
def delete_user():
	pass
	
##def add_user_email():
##	pass

def user_email():
	for u in users_display():
		if u[0][0] == name:
			return u[0][1]
	
def change_user_email():
	pass

def change_user_name():
	pass
	
def users_display():
	return read_csv('users_profile.csv')
	
# User Post CRUD base functions
def create_user_post_file():
	open('user_post.csv','w').write('xxx')
	
def add_post():
	post= print_post_list()
	post.append([user_id, title, content])
	write_csv('user_post.csv',post)
	return post
	
def delete_post():
	pass
	
def edit_post():
	pass
	
def print_post_list():
	return read_csv('user_post.csv')
	
def find_user_post(user_id):
	n=0
	for p in print_post_list():
		if p[n][0]==user_id:
			return p[n][1]
		else:
			n+=1
	
	
def read_user_record(): 
	pass
	
# Second, test functions
def test_user_file_exists():
	pass
	
# 	User Test
def test_user_name():
	pass

def test_user_email():
	pass
	
def test_delete_user():
	pass
	
def test_change_email():
	pass
	
def test_Bill():
	pass
	
def test_add_user_list():
	pass
	
def test_read_user_record():
	pass

# 	User Post Test
def test_print_article_list(): #display all
	pass
	
def test_all_user_posts(): #display all by one user
	pass
	
def test_userfour_kittens(): #search by title and user
	pass

def test_edit_post(): #user id --> title --> change post content
	pass	

def test_post_clear_check(): #evaluate if user's posts are gone when he is deleted
	pass
	
# Main Tests
def test_user_crud():
	pass

def test_user_post_crud():
	pass
	
# Run test
if __name__ == '__main__' :
    test_user_crud()
    #test_article_crud()
