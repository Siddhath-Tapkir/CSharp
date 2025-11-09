/*Accept character from user. If it is capital then display all the
characters from the input characters till Z. If input character is small
then print all the characters in reverse order till a. In other cases
return directly.
*/

public class Character
{
    private char cValue;

    public Character(char c)
    {
        this.cValue = c;
    }

    public void Display()
    {
        if((cValue >= 'a') && (cValue <= 'z'))
        {
            while(cValue >= 'a')
            {
                Console.WriteLine(cValue);
                cValue--;
            }
        }

        else if((cValue >= 'A') && (cValue <= 'Z'))
        {
            while(cValue <= 'Z')
            {
                Console.WriteLine(cValue);
                cValue++;
            }
        }
    }
}

internal class question72
{
    public static void Main(string []A)
    {
        Console.WriteLine("Enter a character");
        char ch = Convert.ToChar(Console.ReadLine());
        Character cobj = new Character(ch);

        cobj.Display();

        cobj = null;
    }
}