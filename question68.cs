//Accept Character from user and check whether the charatcer is digit or not 
using System.IO;

public class CharacterX
{
    private char ch;

    public CharacterX(char c)
    {
        this.ch = c;
    }

    public bool ChkDigit()
    {
        if(((ch >= '0') && (ch <= '9')))
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
}
public class question68
{
    static public void Main(string []A)
    {
        StreamReader srobj = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("Enter a character");

        char ch = (char)srobj.Read();

        CharacterX cobj = new CharacterX(ch);

        bool bFlag = cobj.ChkDigit();

        Console.WriteLine(bFlag);
    }
}