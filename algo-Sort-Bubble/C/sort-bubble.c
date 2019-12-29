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


int main()
{
    int i; 
    
    int* random_data 
        = generate_random_numbers(LOWER, UPPER, NSAMPLE);
        
    for(i = 0 ; i < NSAMPLE ; i++)
        printf(" %d, ", random_data[i]);
    
    bubble_sort(random_data, NSAMPLE);
        
    printf("\n Sort \n");
    for(i = 0 ; i < NSAMPLE ; i++)
        printf(" %d, ", random_data[i]);
    
    return 0;
}