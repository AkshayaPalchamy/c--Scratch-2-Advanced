public class FindingTargets
{ 
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the length of an array:");
		bool nArray2 = int.TryParse(Console.ReadLine(), out int nValue);

		int[] nArray = new int[nValue];

		Console.WriteLine("Enter numbers:");
		for(int i = 0; i < nValue; i++)
		{
			int.TryParse(Console.ReadLine(), out nArray[i]);
		}

		Console.WriteLine("Enter target");
		int.TryParse(Console.ReadLine(), out int target);

		for(int i = 0; i < nArray.Length; i++)
		{
			for(int j = i+1; j < nArray.Length; j++)
			{
				if(nArray[i] + nArray[j] == target)
				{
					Console.WriteLine($"{i},{j}");
					return;
				}
			}
		}
	}
}