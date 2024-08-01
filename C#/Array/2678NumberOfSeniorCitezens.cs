public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;
        for(int i = 0; i< details.Length ; i++){
            string str = details[i];
            str = str.Substring(11, 2);
            int age = int.Parse(str);
            if(age>=60){
                count++;
            } else {
                continue;
            }
        }
        return count;
    }
}