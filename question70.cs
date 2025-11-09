/*
Accept division of student from user and depends on the division
display exam timing. There are 4 divisions in school as A,B,C,D. Exam
of division A at 7 AM, B at 8.30 AM, C at 9.20 AM and D at 10.30 AM.
(Application should be case insensitive)
*/

using System.IO;

public class Division
{
    private char ch;

    public Division(char c)
    {
        this.ch = c;
    }

    public void DisplaySchedule()
    {
        char c = this.ch;
        if((c >= 'A') && (c <= 'Z'))
        {
            c = (char)(c + 32);
        }
        if((c != 'a') && (c != 'b') && (c != 'c') && (c != 'd'))
        {
            return;
        }

        if(c.CompareTo('a') == 0)
        {
            Console.WriteLine("Your Exam is at 7 AM");
        }
        else if(c.CompareTo('b') == 0)
        {
            Console.WriteLine("Your Exam is at 8:30 AM");
        }
        else if(c.CompareTo('c') == 0)
        {
            Console.WriteLine("Your Exam is at 9:20 AM");
        }
        else if(c.CompareTo('d') == 0)
        {
            Console.WriteLine("Your Exam is at 10:30 AM");
        }
    }
}

public class question70
{
    public static void Main(string []A)
    {
        StreamReader srobj = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("Enter your division");

        char cDiv = (char)srobj.Read();

        Division cobj = new Division(cDiv);

        cobj.DisplaySchedule();
    }
}