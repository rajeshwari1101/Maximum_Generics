namespace Maximum_Generics;

internal class MaximumNumber<T> where T : IComparable
{
    private T[] array;
    public MaximumNumber(T[] array)
    {
        this.array = array;
    }
    public void Max(params T[] array)
    {
        this.array = array;
        Array.Sort(array);
        Console.WriteLine($"Max value is: {array[2]}");
    }
}