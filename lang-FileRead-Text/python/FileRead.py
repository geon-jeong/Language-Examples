import os

filename = os.path.abspath('.') + r"\..\DataFiles\data.csv"

#- open a file and read
#- open a file and readlines
#- open a file using with ~ as
#- open text files under a directory and make it one

# open a file and read
def func_file_read(_filename):
    f = open( _filename, 'r')
    read_data = f.read()
    f.close()
    return read_data

#open a file read readlines
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



#- open text files under a directory and make it one
def func_file_read_and_append(_dir_name):
    datastr = ""
    data = []
    file_name = ['1', '2', '3']
    for fcnt in file_name:
        fname = _dir_name+'\%s.%s'%(fcnt,'txt')
        with open(fname, 'r') as f:
            lines = f.readlines()
            for line in lines:
                data.append(line)
                datastr = datastr + line
                #if(line[-1 == '\n']):
                #    datastr = datastr + line[:-1]
    
    return datastr, data     


#
# Examples to read text-data from a file
#
if __name__ == '__main__':
    rdata = func_file_read(filename)
    print(rdata)


    rlines = func_file_readlines(filename)
    for iline, line in enumerate(rlines):
        print('exam1>%4d: %s' %(iline+1, line), end='')


    rlines = func_file_read_wo_close(filename)
    for iline, line in enumerate(rlines):
        print('exam2>%4d: %s' %(iline+1, line), end='')

    datastr, data = func_file_read_and_append(os.path.abspath('.') + r"\..\DataFiles")    
    print(datastr)
    print(data)