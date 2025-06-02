namespace Example_2;

public class GenericStudy
{
    static void Main123()
    {
        var stringList = new GenericList<string>(10);
        stringList.Add("Hello!");
        var stringItem = stringList.Get(0);

        string inputA = "Hello!";
        string inputB = "World!";
        bool isEqual_A_B = GenericList<bool>.Utility.AreaEquals<string>(inputA, inputB);
        Console.WriteLine($"Are A and B Equal? : {isEqual_A_B}");
    }
}

public class GenericList<T>
{
    private T[] items;
    private int Count { get; set; }

    public GenericList(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if (Count < items.Length)
            items[Count++] = item;
    }

    public T Get(int index)
    {
        return items[index];
    }

    public class Utility
    {
        public static bool AreaEquals<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}