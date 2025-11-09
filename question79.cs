/*
1.Write a program which accept string from user and convert it into
lower case.
*/

public class Character
{
    public string ConvertLower(string str)
    {
        char []cStr = str.ToCharArray();
        int i = 0;

        for(i = 0; i < cStr.Length; i++)
        {
            if((cStr[i] >= 'A') && (cStr[i] <= 'Z'))
            {
                cStr[i] = (char)(cStr[i] + 32);
            }
        }

        string nstr = new string(cStr);

        return nstr;
    }
}

internal class question79
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character();

        string sRet = cobj.ConvertLower(str);

        Console.WriteLine(sRet);
    }
}