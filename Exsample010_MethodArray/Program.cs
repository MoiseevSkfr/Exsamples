int[] array = {1,12,31,4,15,15,10,30,28};

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++; //index = index +1;
}
