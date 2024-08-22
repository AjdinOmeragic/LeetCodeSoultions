public class Solution {
    public bool IsPalindrome(string s) {
        var normalizedString = new System.Text.StringBuilder();
        
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                normalizedString.Append(char.ToLower(c));
            }
        }
        string cleanString = normalizedString.ToString();
        int left = 0;
        int right = cleanString.Length - 1;

        while (left < right) {
            if (cleanString[left] != cleanString[right]) {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
