using System;

// Generic class
/*class DataHolder<T>
{
    public T Value;

    public DataHolder(T val)
    {
        Value = val;
    }

    public void Show()
    {
        Console.WriteLine("Value: " + Value);
    }
}

class Program
{
    // Generic method to swap two variables
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Using generic class with int
        DataHolder<int> intHolder = new DataHolder<int>(100);
        intHolder.Show();

        // Using generic class with string
        DataHolder<string> strHolder = new DataHolder<string>("Hello");
        strHolder.Show();

        // Using generic method
        int x = 10, y = 20;
        Console.WriteLine($"\nBefore swap: x = {x}, y = {y}");
        Swap<int>(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");

        string s1 = "Apple", s2 = "Banana";
        Console.WriteLine($"\nBefore swap: s1 = {s1}, s2 = {s2}");
        Swap<string>(ref s1, ref s2);
        Console.WriteLine($"After swap: s1 = {s1}, s2 = {s2}");
    }
}
*/
