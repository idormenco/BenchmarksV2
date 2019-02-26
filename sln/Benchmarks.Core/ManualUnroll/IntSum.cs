namespace Benchmarks.Core.ManualUnroll
{
	public class IntSum
	{
		public int Sum(int[] array)
		{
			int sum = 0;

			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}

			return sum;
		}

		public int SumManualUnroll(int[] array)
		{
			int sum = 0;

			for (int i = 0; i < array.Length; i += 4)
			{
				sum += array[i] + array[i + 1] + array[i + 2] + array[i + 3];
			}

			return sum;
		}

	}
}