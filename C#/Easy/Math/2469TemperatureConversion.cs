public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double kelvin, fahrenheit;
        
        kelvin = celsius + 273.15;
        fahrenheit = celsius * 1.80 + 32.00;

        double[] ans = {kelvin, fahrenheit};

        return ans;
    }
}