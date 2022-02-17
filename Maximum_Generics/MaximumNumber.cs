namespace Maximum_Generics;

internal static class MaximumNumber 
{
    // Finds Max of 3 integers
    public static void IntMax(int num1, int num2, int num3)
    {
        if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            Console.WriteLine($"Max value is: {num1}");
        else if (num2.CompareTo(num3) >= 0)
            Console.WriteLine($"Max value is: {num2}");
        else
            Console.WriteLine($"Max value is: {num3}");
    }

    /// Finds Max of 3 floats
    public static void FloatMax(float num1, float num2, float num3)
    {
        if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
            Console.WriteLine($"Max value is: {num1}");
        else if (num2.CompareTo(num3) >= 0)
            Console.WriteLine($"Max value is: {num2}");
        else
            Console.WriteLine($"Max value is: {num3}");
    }

    /// Finds Max of 3 strings
    public static void StringMax(string str1, string str2, string str3)
    {
        if (str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) >= 0)
            Console.WriteLine($"Max value is: {str1}");
        else if (str2.CompareTo(str3) >= 0)
            Console.WriteLine($"Max value is: {str2}");
        else
            Console.WriteLine($"Max value is: {str3}");
    }
}