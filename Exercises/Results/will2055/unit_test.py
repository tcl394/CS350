from os.path import exists
import csv

class Author:
	def __init__(self, id_num, first_name, last_name, email):
		self.id_num
		self.first_name
		self.last_name
		self.email
	def id_num_read():
		with open('author_ut.csv')as csvfile:
			reader=csv.DictReader(csvfile,id_num)
			for row in reader:
				print(row[0])

a=Author
print(a.id_num_read)
