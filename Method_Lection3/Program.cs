// Вид 1. Метод, который ничего не принимает и ничего не возвращает

// void Method1()
// {
//     Console.WriteLine("Автор ... .");
// }

// Method1();


// Вид 2. Методы, которые что-то принимают, но ничего не возвращают.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count){
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Text", 4);

// Вид 3. Ничего не принимает. Что-то возвращает. Указывается тип возвращаемого значения.
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4. что-то принимает и что-то возвращает.

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//         {
//             result = result + c;
//             i++; 
//         }
//         return result;
// }

// string msg = Method4(10, "  txt");
// Console.WriteLine(msg);

// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//          {
//              result = result + c;
//          }
//          return result;
//  }

//  string msg = Method4(10, "  txt");
// Console.WriteLine(msg);

for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < 11; j++)
    {
        int result = i*j;
        Console.WriteLine($"произведение {i} x {j} = {result}");
    }
    Console.WriteLine();
}