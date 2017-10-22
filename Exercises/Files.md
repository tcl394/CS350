## Files

Reading and writing files is an important part of almost every program.

File Types

* Text Files
* CSV
* JSON
* Objects
* HTML

### Text Files

Text files are the most basic file type.  Many of the other file types use these functions to save the
text strings in the actual files.

* Read text file
* Write text file
* Test text file


```python
# Read the text from a file
def read_file(filepath):
    return open(filepath).read()[:-1]

# Write the text string to a file
def write_file(filepath, text):
    open(filepath, 'w').write(text+"\n")
```


```python
# Test that the file reads and writes the same data
def test_file():
    text = "line1\nline2"
    path = 'test.txt'
    write_file(path, text)
    t = read_file(path)
    # print('text:'+text+'$')
    # print('t:'+t+'$')
    assert(t==text)

# Run test
test_file()
```

### CSV Files

CSV (Comma-separated files) are a common way to store tables.

* Read CSV files
* Write CSV files
* Test CSV files


```python
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
```


```python
# Test that the file reads and writes the same data
def test_csv():
    path = 'test.csv'
    data = [['a', 'b'], ['c', 'd']]
    write_csv(path, data)
    text = read_csv(path)
    assert(text==data)

# Run test
test_csv()
```

### JSON Files

JSON files store serialized JavaScript objects.

* Read JSON file
* Write JSON file
* Test JSON file


```python
from json import loads, dumps

def test_one_object():
    s = {'person': {'name': 'Bob', 'email': 'bob@here.com'}}
    path = 'test.json'
    write_file(path, dumps(s))
    t = loads(read_file(path))
    #print(s)
    assert(s==t)

def test_two_objects():
    s = [{'person': {'name': 'Bob', 'email': 'bob@here.com'}}, 
         {'person': {'name': 'Sue', 'email': 'sue@here.com'}}]
    path = 'test.json'
    write_file(path, dumps(s))
    t = loads(read_file(path))
    #print(s)
    assert(s==t)

test_one_object()
test_two_objects()
```
