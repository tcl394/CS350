print('visual studio setup')

x = '''
External Tools

Title: Test
Command: c:\\program files\\python 3.6.1\\python.exe
Arguments: c:\\users\mark.seaman\\source\hello.py
Directory: c:\\users\mark.seaman\\source

'''

print(x)

def read_csv():
    from csv import reader
    with open('user.csv') as f:
        return [row for row in reader(f)]


def test_read_csv():
    print(read_csv())


test_read_csv()


