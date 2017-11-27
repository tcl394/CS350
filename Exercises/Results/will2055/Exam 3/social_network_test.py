from social_network import *

####################################
#			User Stories		   #
####################################
#	Bob-						   #
#		Friends: Susan, Joe		   #
#		1 post					   #
#	Susan-						   #
#		Friends: Bob			   #
#		3 posts					   #
#	John						   #
#		Friends: none			   #
#		0 posts					   #
#								   #
#	*{Joe doens't use the network} #
####################################

class System_Control_Test:
	def Systest():
		System_Control.sys_reset()

class Bob:
	def Bob_user_test():
		User.register_user('Bob','Elbert','bob@email.com')
	
	def Bob_friend_test():
		User_Friends.read_friendships()
		User_Friends.check_friendship('Bob','Elbert', 'Susan', 'Tucker')
		User_Friends.check_friendship('Bob','Elbert', 'Joe', 'Shmoo')
		User_Friends.add_friendship('Bob','Elbert', 'Susan', 'Tucker')
		User_Friends.add_friendship('Bob','Elbert', 'Joe', 'Shmoo')
	
	def Bob_post_test():
		Post.create_post_log('Bob','Elbert')
		Post.create_post("Hello World!")
		Post.delete_post(1)
		Post.create_post("Hello World! How are you?")
	
	def Bob_full_test():
		Bob.Bob_user_test()
		Bob.Bob_friend_test()
		Bob.Bob_post_test()
	
class Susan:
	def Susan_user_test():
		User.register_user('Susan','Tucker','John@email.com')
	
	def Susan_friend_test():
		User_Friends.read_friendships()
		User_Friends.check_friendship('Susan','Tucker', 'Bob', 'Elbert')
		User_Friends.add_friendship('Susan','Tucker', 'Bob', 'Elbert')
	
	def Susan_post_test():
		Post.create_post_log('Susan','Tucker')
		Post.create_post("Hello World!")
		Post.create_post("I'm bored")
		Post.create_post("This app is interesting")
	
	def Susan_full_test():
		Susan.Susan_user_test()
		Susan.Susan_friend_test()
		Susan.Susan_post_test()
	
class John:
	def John_user_test():
		User.register_user('John','Smith','John@email.com')
	
	def John_full_test():
		John.John_user_test()

class Main_Test:
	def full_test():
		System_Control_Test.Systest()
		Bob.Bob_full_test()
		Susan.Susan_full_test()
		John.John_full_test()

main=Main_Test()

main.full_test
