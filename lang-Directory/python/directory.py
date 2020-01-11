import os, glob
import shutil
from os.path import exists, isdir, isfile

# get current directory
def get_working_directory():
    wd = os.getcwd()
    return wd

# create new directory
def create_directory( _name):
    try:
        # check whether it is exist
        if not exists(_name):
            os.mkdir(_name)
    except Exception as e:
        print(e)

# change current working directory
def change_directory(_path):
    os.chdir(_path)
    return os.getcwd()

# remove directory
def remove_directory(_path):
    try:
        os.rmdir(_path)
    except Exception as e:
        print(e)
    return os.getcwd()

# removie a directory with sub-directory
def remove_directory_with_sub(_path):
    try:
        shutil.rmtree(_path)
    except Exception as e:
        print(e)
    return os.getcwd()

# print file and directory info
def get_filenames_in_directory(_path):
    
    nodes = os.listdir()
    
    for dir in nodes:
        if not isdir(dir):
            print('>File: %s' %dir)
    
    for file in nodes:
        if not isfile(file):
            print('>Dir: %s' %file)
    
# print file and directory info with specific file extention
def get_files_with_extention(_filetype):
    files = glob.glob(_filetype)
    print(files)
    return files


#
# Examples regarding to directory work
#
if __name__ == '__main__':

    print(get_working_directory())
    create_directory('test')
    change_directory('test')    
    print('cwd = ' + get_working_directory())
        
    create_directory('test1')    
    f1= open("test1.txt","w+")
    f2= open("test2.dat","w+") 
    get_filenames_in_directory(os.getcwd())
    get_files_with_extention('*.txt')

    f1.close()
    f2.close()
    change_directory('../')    
    print('cwd = ' + get_working_directory())   

    remove_directory_with_sub('test')
    