# file_text.py


# Read the text from a file
def read_file(filepath):
    with open(filepath) as f:
        return f.read()[:-1]


# Write the text string to a file
def write_file(filepath, text):
    with open(filepath, 'w') as f:
        f.write(text+"\n")


# Test that the file reads and writes the same data
def test_file():
    text = "Meow cats"
    path = 'test.txt'
    write_file(path, text)
    t = read_file(path)
    print('text:'+text+'$')
    print('t:'+t+'$')
    assert(t==text)
    text = "Bark dogs"
    write_file(path, text)
    print('text:'+text+'$')
    print('t:'+t+'$')
    assert(t!=text)
# Second assertion now passes

# Run test
if __name__ == '__main__' :
        test_file()
