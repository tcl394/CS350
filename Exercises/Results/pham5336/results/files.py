# files.py

from csv import reader, writer


# Read rows and columns from a CSV file
def read_csv(filepath):
    with open(filepath) as f:
        return [row for row in reader(f) if row]


# Read the text from a file
def read_file(filepath):
    with open(filepath) as f:
        return f.read()[:-1]


# Write rows and columns to a CSV file
def write_csv(filepath, data):
    with open(filepath, 'w') as f:
        w = writer(f)
        for row in data:
            w.writerow(row)


# Write the text string to a file
def write_file(filepath, text):
    with open(filepath, 'w') as f:
        f.write(text+"\n")
