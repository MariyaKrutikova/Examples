// Дан текст. В тексте необходимо заменить все пробелы черточками,маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

String Replase(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
        if (text[i] == OldValue) 
        {
            result  = result + $"{NewValue}";
        }
        else
        {
            result  = result + $"{text[i]}";
        }
    return result;    
}    

string newText = Replase(text, 'с', 'С');
Console.WriteLine(newText);
