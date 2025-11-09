// program to divide two numbers
internal class question1
{
    public float Divide(int iNo1, int iNo2)
    {
        if(iNo2 > iNo1)
        {
            return -1;
        }
        
        float iAns = 0.0f;

        iAns = iNo1 / iNo2;

        return iAns;
    }
}