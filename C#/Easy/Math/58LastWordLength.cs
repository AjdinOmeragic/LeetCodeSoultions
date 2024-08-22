public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int spaceCount = 0;
        int lastWordLength = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                spaceCount++;
                if (lastWordLength > 0)
                {
                    break;
                }
            }
            else
            {
                lastWordLength++;
            }
        }

        return lastWordLength;
    }
}
