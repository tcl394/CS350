from csv import reader, writer

# Read rows and columns from a CSV File
def read_csv(filepath):
    with open(filepath) as f:
        return [row for row in reader(f) if row]


# Write to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'wt') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)

# test functionality with author csv file
def test_author():
    path = 'author.csv'
    data = [['test','test'],['test','test']]
    write_csv(path, data)
    text = read_csv(path)
    assert(text==data)
    assert(text!=data)


# test functionality with articles csv file
def test_article():
    path = 'articles.csv'
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
    path = 'author.csv'
    text = read_csv(path)
    data = [[name, email]]
    text += data
    write_csv(path, text)
    text = read_csv(path)
    print(text)
    

def read_author():
    ## stuff
    pass

def update_author():
    ##stuff
    pass

def delete_author():
    ##stuff
    pass

if __name__ == '__main__':
    #other()
    create_author('nik','jone2032@bears.unco.edu')
