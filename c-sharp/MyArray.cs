namespace c_sharp;

public class MyArray
{
    int[] a = new int[5]; // Static Array
    List<int> b = new List<int>(); //Dynamic Array

    public MyArray()
    {
        a = [1,2];
        b = new List<int> {6,7};
    }

    public void Operate()
    {
        // Access
        Console.WriteLine(a[1]);
        Console.WriteLine(b[1]);

        // Search
        Console.WriteLine(a.Contains(2));//O(n)
        Console.WriteLine(b.Contains(6));//O(n)

        // Insert
        b.Insert(2, 8); //O(n)

        // Delete
        b.Remove(7); //O(n)
    }
}