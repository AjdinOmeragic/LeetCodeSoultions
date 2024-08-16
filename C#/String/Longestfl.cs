public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        int index = 0;
        var sb = new StringBuilder();
        while (index < strs[0].Length)
        {
            char ch = strs[0][index];
            for (int i = 1; i < strs.Length; i++)
            {
                if (index == strs[i].Length || strs[i][index] != ch)
                {
                    return sb.ToString();
                }
            }
            sb.Append(ch);
            index++;
        }
        return sb.ToString();
    }
}