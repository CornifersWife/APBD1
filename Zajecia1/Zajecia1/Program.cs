// See https://aka.ms/new-console-template for more information

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello, World! s");
        Console.WriteLine("Do commita 2");
        Console.WriteLine("Do commita 3");
    }

    public static float AvgValue(int[] numbers) {
        float avgValue = 0f;
        for (int i = 0; i < numbers.Length; i++) {
            avgValue += numbers[i];
        }

        return (avgValue / numbers.Length);
    }

    public static int MaxValue(int[] numbers) {
        int maxValue = numbers[0];
        for (int i = 0; i < numbers.Length; i++) {
            if (maxValue< numbers[i]) {
                maxValue = numbers[i];
            }
        }
        return maxValue;
    }
}