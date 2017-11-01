from csv import reader, writer
import os.path


# Read rows and columns from a CSV File
def read_csv(filepath):
    create_csv(filepath)
    with open(filepath) as f:
        return [row for row in reader(f) if row]


# Write to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'wt') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)

# create csv file
def create_csv(filename):
    if '.csv' not in filename:
        filename += '.csv'
    if os.path.isfile(filename)== False:
        open(filename, 'w')
    
        
# test functionality with author csv file
def test_author():
    path = 'author.csv'
    create_csv(path)
    data = [['test','test'],['test','test']]
    write_csv(path, data)
    text = read_author()
    assert(text==data)
    #assert(text!=data)


# test functionality with articles csv file
def test_article():
    path = 'articles.csv'
    create_csv(path)
    data = [['test','test'],['test2','test2']]
    write_csv(path, data)
    text = read_csv(path)
    assert(text==data)
    assert(text!=data)


def other():
    path = 'author.csv'
    data = [['name1', 'test'],['name2','test']]
    write_csv(path, data)
    text = read_csv(path)
    print(text)
    data += [['test','test']]
    write_csv(path, data)
    text = read_csv(path)
    print(text)
    data = [['test','test']]
    write_csv(path, data)
    text = read_csv(path)
    print(text)
    create_author('nik','jone2032@bears.unco.edu')


def create_author(name, email):
    create_csv('author.csv')
    path = 'author.csv'
    text = read_csv(path)
    data = [[name, email]]
    text += data
    write_csv(path, text)
    text = read_csv(path)
    print(text)
    

def read_author():
    path = 'author.csv'
    create_csv(path)
    return read_csv(path)

def test_read_author():
    text = read_author()
    print (text)
    
def update_author():
    ##stuff
    pass

def delete_author():
    ##stuff
    pass

def test_create_csv():
    create_csv('article')
    assert(os.path.isfile('article.csv'))

if __name__ == '__main__':
    test_create_csv()
    test_author()

    #other()
    create_author('nik','jone2032@bears.unco.edu')
