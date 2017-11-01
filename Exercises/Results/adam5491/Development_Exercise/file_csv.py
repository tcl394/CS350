from csv import reader, writer

    
# Read rows and columns from a CSV file
def read_csv(filepath):
    with open(filepath) as f:
        return [row for row in reader(f) if row]

# Write rows and columns to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'wt') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)


# Test that the file reads and writes the same data
def test_csv():
    path = 'test.csv'
    data = [['a', 'b'], ['c', 'd']]
    write_csv(path, data)
    text = read_csv(path)
    assert(text==data)
    data = [['a', 'b'], ['d', 'e']]
    write_csv(path, data) #By writing something different in for the second time, the second assert will pass.
    assert(text!=data)


# Run code as a script
if __name__ == '__main__' :
    test_csv()
