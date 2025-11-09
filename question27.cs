// Accept single digit number from user and print it into word.
internal class question27
{
    public void PrintNumber(int iNo)
    {
        if(iNo < 0)
        {
            iNo = -(iNo);
        }

        if(iNo == 0)
        {
            Console.WriteLine("Zero");
        }
        else if(iNo == 1)
        {
            Console.WriteLine("One");
        }
        else if(iNo == 2)
        {
            Console.WriteLine("Two");
        }
        else if(iNo == 3)
        {
            Console.WriteLine("Three");
        }
        else if(iNo == 4)
        {
            Console.WriteLine("Four");
        }

        else if(iNo == 5)
        {
            Console.WriteLine("Five");
        }
        else if(iNo == 6)
        {
            Console.WriteLine("Six");
        }
        else if(iNo == 7)
        {
            Console.WriteLine("Seven");
        }
        else if(iNo == 8)
        {
            Console.WriteLine("Eight");
        }
        else if(iNo == 9)
        {
            Console.WriteLine("Nine");
        }
        else if(iNo == 10)
        {
            Console.WriteLine("Ten");
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
} 