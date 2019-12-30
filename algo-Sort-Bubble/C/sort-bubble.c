/*
 * Bubble Sort 
 * Big(O) = N^2
 */
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define NSAMPLE 10
#define LOWER 0
#define UPPER 100

#define TRACE_DATA

void print_data(int* _data, int _nsize, int _i, int _j);

/*
 * Bubble Sorting 
 */ 
void bubble_sort(int* _data, int _nsize)
{
    int min, small, temp, i, j;   
    
    for(i = 0; i < _nsize-1; i++) {
         for(j = _nsize-1; j > i; j--){
            if(_data[j] < _data[j-1]) {
                // change small data 
                temp = _data[j];
                _data[j] = _data[j-1];
                _data[j-1] = temp;
                print_data(_data, _nsize, i, j);
            } // end of if
        } // end of j-loop
    } // end of i-loop
}

/*
 * Generate Random Numbers
 * Copied from random-int.c 
 */
int* generate_random_numbers(int _lower, int _upper, int _count)
{
    int icnt;
    int* rvalues = (int*)malloc(_count * sizeof(int));
    
    // seed for random values. current time
    srand(time(0)); 
    for(icnt = 0; icnt < _count; icnt++) {
        rvalues[icnt] = 
            (rand() % (_upper - _lower +1)) + _lower;
    }
    
    return rvalues;
}

void print_data(int* _data, int _nsize, int _i, int _j)
{
    #ifdef TRACE_DATA
        printf("i= %2d, j=%2d, j-1=%2d [ ", _i, _j, _j-1);
        for(int icnt = 0; icnt < _nsize; icnt++)
            printf("%d, ", _data[icnt]);        
        printf("] \n");
    #endif 
}

int main()
{
    int i; 
    
    int* random_data 
        = generate_random_numbers(LOWER, UPPER, NSAMPLE);
        
    printf("\n Data \n");    
    print_data(random_data, NSAMPLE, -1, -1);
    
    printf("\n Sorting \n");
    bubble_sort(random_data, NSAMPLE);
        
    printf("\n Result \n");
    print_data(random_data, NSAMPLE, -1, -1);
    
    return 0;
}