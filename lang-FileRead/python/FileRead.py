import os

filename = os.path.abspath('.') + r"\..\DataFiles\data.csv"

# open a file and read
def func_file_read(_filename):
    f = open( _filename, 'r')
    read_data = f.read()
    f.close()
    return read_data

#open a file ad readlines
def func_file_readlines(_filename):
    f = open( _filename, 'r')
    lines = f.readlines()
    f.close()
    return lines


# open a file using with ~ as
# no need to call close()
def func_file_read_wo_close(_filename):
    with open( _filename, 'r') as f:
        lines = f.readlines()
    return lines


#
# Examples to read text-data from a file
#

rdata = func_file_read(filename)
print(rdata)


rlines = func_file_readlines(filename)
for iline, line in enumerate(rlines):
    print('exam1>%4d: %s' %(iline+1, line), end='')


rlines = func_file_read_wo_close(filename)
for iline, line in enumerate(rlines):
    print('exam2>%4d: %s' %(iline+1, line), end='')
