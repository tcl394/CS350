from csv import reader, writer

    
# Read rows and columns from a CSV file
def read_csv(filepath):
    with open(filepath) as file:
        #return [row for row in reader(f) if row]
        for tt in file:
            print(tt.rstrip('\n'))

            
# Write rows and columns to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'a') as file:
        w = writer(file)
        for row in data:
            w.writerow(row)


# Test that the file reads and writes the same data
def test_csv(fname,lname):
    path = 'test.csv'
    data = [[fname, lname]]
    write_csv(path, data)
    read_csv(path)
    
    

    #assert(text==data)
    #assert(text!=data)
# Run code as a script
#if __name__ == '__main__' :
#   test_csv()
#   test_csv('hello','world')
#   test_csv('a new','world')
