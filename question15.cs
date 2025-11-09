// accept a character from user and check wheather it is a vowel or not
internal class question15
{
    public bool CheckVowel(char cValue)
    {
        char ch = cValue;

        if(cValue >= 'A' && cValue <= 'Z')
        {
            ch = (char)(cValue + 32);
        }

        if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}