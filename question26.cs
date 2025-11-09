// Write a program which accept number from user and if number is less than 50
// then print small , if it is greater than 50 and less than 100 then print medium, if it is
// greater than 100 then print large.

internal class question26
{
    public void Display(int iNo)
    {
        if(iNo <= 50)
        {
            Console.WriteLine("Small");
        }
        else if(iNo > 50)
        {
            Console.WriteLine("Medium");
        }
        else
        {
            Console.WriteLine("Large");
        }
    }
} 