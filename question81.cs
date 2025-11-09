/*3.Write a program which accept string from user and toggle the case.
*/

public class Character
{
    public string Toggle(string str)
    {
        char []cStr = str.ToCharArray();
        int i = 0;

        for(i = 0; i < cStr.Length; i++)
        {
            if((cStr[i] >= 'a') && (cStr[i] <= 'z'))
            {
                cStr[i] = (char)(cStr[i] - 32);
            }
            else if((cStr[i] >= 'A') && (cStr[i] <= 'Z'))
            {
                cStr[i] = (char)(cStr[i] + 32);
            }
        }

        string nstr = new string(cStr);

        return nstr;
    }
}

internal class question81
{
    static public void Main(string []A)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        Character cobj = new Character();

        string sRet = cobj.Toggle(str);

        Console.WriteLine(sRet);
    }
}