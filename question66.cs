//Accept Character from user and check whether it is alphabet or not (A-Z a-z).
using System.IO;

public class CharacterX
{
    private char ch;

    public CharacterX(char c)
    {
        this.ch = c;
    }

    public bool ChkChar()
    {
        if(((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z')))
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
}
public class question66
{
    static public void Main(string []A)
    {
        StreamReader srobj = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("Enter a character");

        char ch = (char)srobj.Read();

        CharacterX cobj = new CharacterX(ch);

        bool bFlag = cobj.ChkChar();

        Console.WriteLine(bFlag);
    }
}