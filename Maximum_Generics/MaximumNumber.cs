namespace Maximum_Generics;

internal class Maximum<T> where T : IComparable
{
    // T array for sorting and to find max
    private T[] array;

    // Initializes a new instance of the <see cref="Maximum{T}"/> class.
    public Maximum(T[] array)
    {
        this.array = array;
    }

    // Determines the maximum of the parameters.
    public void Max(params T[] array)
    {
        this.array = array;
        Array.Sort(array);
        PrintMax(array);
    }

    // Prints the maximum.
    private void PrintMax(T[] value)
    {
        Console.WriteLine($"Max value is: {array[2]}");
    }
}