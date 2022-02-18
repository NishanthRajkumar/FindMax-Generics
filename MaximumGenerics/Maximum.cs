namespace MaximumGenerics;

internal class Maximum<T> where T : IComparable
{
    // T array for sorting and to find max
    private T[] array;

    /// <summary>
    /// Initializes a new instance of the <see cref="Maximum{T}"/> class.
    /// </summary>
    public Maximum(T[] array)
    {
        this.array = array;
    }

    /// <summary>
    /// Determines the maximum of the parameters.
    /// </summary>
    public void Max(params T[] array)
    {
        this.array = array;
        Array.Sort(array);
        PrintMax(array);
    }

    /// <summary>
    /// Prints the maximum.
    /// </summary>
    private void PrintMax(T[] value)
    {
        Console.WriteLine($"Max value is: {value[^1]}");
    }
}