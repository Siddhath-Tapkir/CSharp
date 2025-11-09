/*
Accept Character from user and check whether it is special symbol
or not (!, @, #, $, %, ^, &, *).
*/

public class Character
{
    private char cValue;

    public Character(char c)
    {
        this.cValue = c;
    }

    public bool ChkChar()
    {
        bool bFlag = false;
        if((cValue == '!') || (cValue == '@') || (cValue == '#') || (cValue == '$') || (cValue == '%') || (cValue == '^') || (cValue == '&') || (cValue == '*'))
        {
            bFlag = true;
        }

        return bFlag;
    }
}

internal class question73
{
    public static void Main(string []A)
    {
        Console.WriteLine("Enter a character");
        char ch = Convert.ToChar(Console.ReadLine());
        Character cobj = new Character(ch);

        bool bRet = cobj.ChkChar();

        Console.WriteLine(bRet);

        cobj = null;
    }
}