import os
import math
# it may need to install numpy 
# #pip install numpy
import numpy as np

filename = os.path.abspath('.') + r"\..\DataFiles\data.csv"

# open a file using with ~ as
# no need to call close()
def func_file_read_wo_close(_filename):
    with open( _filename, 'r') as f:
        lines = f.readlines()
    return lines

# calcuate mean
def func_mean_wo_numpy(_data):
    sum_val = sum(_data)
    length = len(_data)
    return sum_val/length

# calculate variance 
def func_variation_wo_numpy(_data):

    sum_pow2 = 0
    mean = func_mean_wo_numpy(_data)
    
    #sum of pow(data-mean, 2)
    for data in _data:
        sum_pow2 += (data - mean) ** 2

    # (sum of pow(data-mean, 2))/N
    return sum_pow2/len(_data)

# calcuate standard deviation
def func_std_deviation_wo_numpy(_data):

    variation = func_variation_wo_numpy(_data)
    return math.sqrt(variation)


#
# Examples to read text-data from a file
#
if __name__ == '__main__':

    # read text data file
    rlines = func_file_read_wo_close(filename)

    # convert the string array to float data array 
    str_array = np.array(rlines)
    fdata = str_array.astype(np.float)


    # calculate data w/o numpy
    mean = func_mean_wo_numpy(fdata)
    variation = func_variation_wo_numpy(fdata)
    std_deviation = func_std_deviation_wo_numpy(fdata)

    # calculate data using numpy    
    mean_np = np.mean(fdata)
    variation_np = np.var(fdata)
    std_deviation_np = np.std(fdata)

    print('mean=\t\t ', mean, '\tnumpy_mean= ', mean_np, 
                    '\tdiff= ', abs(mean - mean_np), end='\n')
    print('variatioin=\t ', variation,'\tnumpy_var= ', variation_np, 
                    '\tdiff= ', abs(variation - variation_np), end='\n')
    print('std deviation= ', std_deviation, '\tnumpy_std= ', std_deviation_np, 
                    '\tdiff=', abs(std_deviation - std_deviation_np), end='\n')

