int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > rusult) result = arg2;
    if(arg3 > rusult) result = arg3;
    return result;
}


int a1 = 15;
int a2 = 21;
int a3 = 5;
int b1 = 12;
int b2 = 23; 
int b3 = 33;
int c1 = 13;
int c2 = 23;
int c3 = 333;

int max1 = max(a1, b1, c1);

Console.WriteLine(max1);