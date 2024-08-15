public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            HashSet<char> seenChars = new HashSet<char>();
            int currentLength = 0;

            for (int j = i; j < s.Length; j++) {
                if (seenChars.Contains(s[j])) {
                    break;
                }
                seenChars.Add(s[j]);
                currentLength++;
            }
            if (currentLength > maxLength) {
                maxLength = currentLength;
            }
        }
        return maxLength;
    }
}
