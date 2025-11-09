// accept a character from user and convert the case of that character
using System;
internal class question14
{
    public void ChangeCase(char cValue)
    {
        if(cValue >= 'a' && cValue <= 'z')
        {
            char ch = (char)(cValue - 32);
            Console.WriteLine(ch);
        }
        else if(cValue >= 'A' && cValue <= 'Z')
        {
            char ch = (char)(cValue + 32);
            Console.WriteLine(ch);
        }
    }
}