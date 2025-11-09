// accept a number from user and if that number is less than 10 print Hello otherwise print Demo
internal class question8
{
    public void DisplayHelloDemo(int iNo)
    {
        if(iNo == 0)
        {
            return;
        }
        
        if(iNo < 10)
        {
            Console.WriteLine("Hello");
        }
        else
        {
            Console.WriteLine("Demo");
        }
    }
}