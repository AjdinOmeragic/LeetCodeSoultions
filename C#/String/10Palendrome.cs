public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string strReversed = new string(charArray);
        int count = 0;
        for (int i = 0; i < str.Length; i++) {
            if (str[i] == strReversed[i]) {
                count++;
            }
        }
        if (count == str.Length) {
            return true;
        }
        return false;
    }
}
