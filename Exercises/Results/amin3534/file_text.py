# file_text.py


# Read the text from a file
def read_file(filepath):
        f = open(filepath,"r")
        return f.read()[:-1]
        f.close()


# Write the text string to a file
def write_file(filepath, text):
        f = open(filepath, "w")
        f.write(text+"\n")
        f.close()


# Test that the file reads and writes the same data
def test_file():
    text = "line1\nline2 test"
    path = 'test.txt'
    write_file(path, text)
    t = read_file(path)
    print('text:'+text+'$')
    print('t:'+t+'$')
    assert(t==text)
    assert(t!=text)


# Run test

if __name__ == '__main__' :
    test_file()
