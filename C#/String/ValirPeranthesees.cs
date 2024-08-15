public class Solution {
    public bool IsValid(string s) {
        int roundOpen = 0;
        int squareOpen = 0;
        int curlyOpen = 0;
        
        for (int i = 0; i < s.Length; i++) {
            char ch = s[i];
            
            if (ch == '(') {
                roundOpen++;
            } else if (ch == ')') {
                if (roundOpen == 0) return false;
                roundOpen--;
            } else if (ch == '[') {
                squareOpen++;
            } else if (ch == ']') {
                if (squareOpen == 0) return false; 
                squareOpen--;
            } else if (ch == '{') {
                curlyOpen++;
            } else if (ch == '}') {
                if (curlyOpen == 0) return false; 
                curlyOpen--;
            }
        }
        return roundOpen == 0 && squareOpen == 0 && curlyOpen == 0;
    }
}
