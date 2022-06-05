int example;
int Sum(int a, int b) 
{
    example = a + b;    // Global Values
    int result = a + b; // Local values
    return result;
}

example = Sum(1, 2);
//result not used

