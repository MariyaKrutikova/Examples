// Упорядочить массив

int[] arr =  {6, 8, 3, 2, 1, 4, 5, 7, 8, 16, 0, 76, 20, 23, 11};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] } ");
    }
    //Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count-1; i++)
    {
       int minposition = i;
        for (int j = i ; j < count; j++)
        {            
            if (array[j] < array[minposition]) 
            {
                minposition = j;
            }            
        }  
        int memory = array[i];
        array[i] = array[minposition];
        array[minposition] = memory;          
    }
}



PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
