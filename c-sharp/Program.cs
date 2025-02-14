using c_sharp;

Console.WriteLine("Data Structures and Algorithms.");

BigO bo = new BigO();
int[] arr = new int[5];
arr = [1, 2, 3, 4, 5];
Console.WriteLine("Big O:");
Console.WriteLine(bo.FunChallenge(arr));
bo.PrintFirstFiveItems(arr);

MyArray ma = new MyArray();
int[] indices = ma.TwoSum(new int[] {1,3,7,2,9}, 11);
Console.WriteLine("Two Sum:");
Console.WriteLine(indices[0].ToString());
Console.WriteLine(indices[1].ToString());
int[] indices1 = ma.TwoSumDict(new int[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11);
Console.WriteLine("Two Sum:");
Console.WriteLine(indices1[0].ToString());
Console.WriteLine(indices1[1].ToString());