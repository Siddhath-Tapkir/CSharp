/*Accept character from user. If character is small display its
corresponding capital character, and if it small then display its
corresponding capital. In other cases display as it is.
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
            cValue = (char)(cValue - 32);
            Console.WriteLine(cValue);
        }

        else if((cValue >= 'A') && (cValue <= 'Z'))
        {
            cValue = (char)(cValue + 32);
            Console.WriteLine(cValue);
        }
        
        else
        {
            Console.WriteLine(cValue);
        }
    }
}

internal class question71
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