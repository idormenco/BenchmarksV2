using System;
using System.Collections.Generic;

namespace Benchmarks.Core
{
	public static class Utils
	{
		public static T[] FillByPattern<T>(string branchPattern, int size, T trueValue, T falseValue)
		{
			Console.WriteLine(branchPattern);
			T[] regularData = new T[size];

			for (int i = 0, j = 0; i < size; i++)
			{
				regularData[i] = branchPattern[j] == '1' ? trueValue : falseValue;
				j = (j + 1) % branchPattern.Length;
			}

			return regularData;
		}

		public static T[] ShuffledCopyOf<T>(T[] array)
		{
			var newArray = new T[array.Length];

			Array.Copy(array, newArray, array.Length);

			Shuffle(newArray);

			return newArray;
		}

		private static void Shuffle<T>(T[] array)
		{
			Random rnd = new Random(0xBAD_BEE);

			for (int i = array.Length; i > 1; i--)
			{
				Swap(array, i - 1, rnd.Next(i));
			}
		}

		private static void Swap<T>(T[] array, int i0, int i1)
		{
			T x = array[i0];
			array[i0] = array[i1];
			array[i1] = x;
		}

		public static void Fill<T>(this IList<T> col, int fromIndex, int toIndex, T value)
		{
			if (fromIndex > toIndex)
			{
				throw new ArgumentOutOfRangeException(nameof(fromIndex));
			}

			for (var i = fromIndex; i <= toIndex; i++)
			{
				col[i] = value;
			}
		}

		public static int[] SortedCopyOf(int[] source)
		{
			var clone = new int[source.Length];

			Array.Copy(source,clone,source.Length);
			Array.Sort(clone);

			return clone;
		}

		public static double[] NewRandomDoubleArray(int size)
		{
			var values = new double[size];
			Random rnd = new Random(0xBAD_BEE);

			for (int i = 0; i < size; i++)
			{
				values[i] = Math.Round(rnd.NextDouble() * 256, 4);
			}

			return values;
		}

		public static int[] NewRandomIntArray(int size)
		{
			var values = new int[size];
			Random rnd = new Random(0xBAD_BEE);

			for (int i = 0; i < size; i++)
			{
				values[i] = rnd.Next(256);
			}

			return values;
		}
	}
}