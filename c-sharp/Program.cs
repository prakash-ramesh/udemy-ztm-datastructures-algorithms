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