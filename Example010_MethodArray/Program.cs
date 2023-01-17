int [] array = {11, 72, 23, 4, 45, 16, 87, 68};
int n = array.Length;
int index = 0;
int find = 45;

while (index < n) 
{
    if (array[index] == find) 
        {
            Console.WriteLine(index);
            break; 
        }
               index++;
 } 



