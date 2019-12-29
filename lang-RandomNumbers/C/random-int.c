#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define NSAMPLE 10
#define LOWER 0
#define UPPER 100

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
    
    return 0;
}