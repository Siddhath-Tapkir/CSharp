/*
1.Write a program which accept string from user and convert it into
upper case.
*/

public class Character
{
    public string ConvertUpper(string str)
    {
        char []cStr = str.ToCharArray();
        int i = 0;

        for(i = 0; i < cStr.Length; i++)
        {
            if((cStr[i] >= 'a') && (cStr[i] <= 'z'))
            {
                cStr[i] = (char)(cStr[i] - 32);
            }
        }

        string nstr = new string(cStr);

        return nstr;
    }
}

internal class question80
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character();

        string sRet = cobj.ConvertUpper(str);

        Console.WriteLine(sRet);
    }
}