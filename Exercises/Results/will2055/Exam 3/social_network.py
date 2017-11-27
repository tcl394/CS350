#social_network.py
from os import *
from os.path import exists
from files import read_csv, read_file, write_csv, write_file

class User:
	
	def read_users():
		read_csv('users.csv')

	def check_user(first_name,last_name):
		for u in read_users():
			if u[0] == first_name & u[1] == last_name:
				return True
			else:
				return False	
	
	def register_user(first_name,last_name,email):
		if check_user(first_name,last_name) == False:
			users = read_users()
			users.append([first_name,last_name,email])
			write_csv('users.csv', users)
			return users
		else:
			pass
	
class User_Friends(User):
	
	def read_friendships():
		read_csv('user_friends.csv')
	
	def check_friendship(base_first_name,base_last_name,connect_first_name,
	connect_last_name):
		if User.check_user(connect_first_name,connect_last_name) == True:
			for i in read_friendships():
				for n in range(len(i)):
					friends.append(i[n],i[n+1])
			return friends
		else:
			print(connect_first_name+' '+connect_last_name+' is not a user')
	
	def add_friendship(base_first_name,base_last_name,connect_first_name,
	connect_last_name):
		for i in read_friendships():
			if a[0] == base_first_name & a[1] == base_last_name:
				pass

class Post:
	
	def create_post_log(first_name,last_name):
		open(first_name+'_'+last_name+'_postlogger.csv','w').write('xxx')
	
	def read_user_posts(first_name,last_name):
		for p in read_csv(first_name+'_'+last_name+'_postlogger.csv'):
			return a[0,1];
	
	def read_user_single_post(post_num):
		posts=read_csv(first_name+'_'+last_name+'_postlogger.csv')
		for i in posts[i]:
			if posts[0] == post_num:
				return posts[1]
	
	def delete_post(post_num):
		posts=read_csv(first_name+'_'+last_name+'_postlogger.csv')
		for i in posts[i]:
			if posts[0] == post_num:
				del posts[1]
	
	def create_post(post_content):
		posts=read_csv(first_name+'_'+last_name+'_postlogger.csv')
		for i in posts:
			num=i
		posts.append([num,post_content])
		write_csv(first_name+'_'+last_name+'_postlogger.csv', posts)
	
class System_Control:
	
	def create_friends_database():
		open('user_friends.csv','w').write('xxx')
		User.read_users()
	
	def create_user_database():
		open('users.csv', 'w').write('xxx')
	
	def sys_reset():
		os.remove('users.csv')
		os.remove('user_friends.csv')
		for u in read_users():
			os.remove(u[0]+'_'+u[1]+'_postlogger.csv')
		create_user_database()
		create_friends_database()
