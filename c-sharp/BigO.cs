namespace c_sharp;

public class BigO
{
    public BigO()
    {
    }

    private void AnotherFunction()
    {
        // some logic
    }

    // 2 + n + n + 1 => 3 + 2n => 2n => n | worst-case, drop constants
    // O(n)
    public int FunChallenge(int[] input)
    {
        int a = 10; // O(1)
        a = 50 + 3; // O(1)

        for (int i = 0; i < input.Length; i++)
        { // worst-case
            AnotherFunction(); // O(n) 
            bool stranger = true; // O(n)
            if (stranger)
            {
                a = a + 1; // O(n)
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            AnotherFunction(); // O(n)
        }

        return a; // O(1)
    }

    // 1+1+1+1+1 => 5 => 1
    // O(1)
    public void PrintFirstFiveItems(int[] input)
    {
        Console.WriteLine(input[0]); // O(1)
        Console.WriteLine(input[1]); // O(1)
        Console.WriteLine(input[2]); // O(1)
        Console.WriteLine(input[3]); // O(1)
        Console.WriteLine(input[4]); // O(1)
    }
}