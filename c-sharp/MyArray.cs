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

    public int[] TwoSum(int[] nums, int target)
    {
        int[] indices = new int[2];

        if(nums.Length <= 1)
        {
            return indices;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            int num_to_find = target - nums[i];
            for(int j = i+1; j < nums.Length; j++)
            {
                if(num_to_find == nums[j])
                {
                    indices[0] = i;
                    indices[1] = j;
                    return indices;
                }
            }
        }

        return indices;
    }

    public int[] TwoSumDict(int[] nums, int target)
    {
        int[] indices = new int[2];

        if(nums.Length <= 1)
        {
            return indices;
        }

        Dictionary<int, int> ntfMap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int num_to_find = target - nums[i];
            
            if (!ntfMap.ContainsKey(nums[i])) {
                if (!ntfMap.ContainsKey(num_to_find)) {
                    ntfMap.Add(num_to_find, i);
                } else {
                    ntfMap[num_to_find] = i;
                }
            } else {
                indices[0] = ntfMap[nums[i]];
                indices[1] = i;
                return indices;
            }
        }

        return indices;
    }
}