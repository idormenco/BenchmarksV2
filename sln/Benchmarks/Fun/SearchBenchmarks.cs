using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Fun
{
	public class SearchBenchmarks
	{
		public int[] MyArray = Enumerable.Range(1, Size).ToArray();

		[Params( 99999)]
		public int SearchedElement;

		private const int Size = 100000;
		[Benchmark(OperationsPerInvoke = Size)]
		public bool IonsSearch()
		{
			return NaiveSearchAlgorithm(MyArray, SearchedElement);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool BinarySearch()
		{
			return BinarySearchAlgorithm(MyArray, SearchedElement);
		}

		private bool BinarySearchAlgorithm(int[] array, int searchedElement)
		{
			int min = 0;
			int max = array.Length - 1;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (searchedElement == array[mid])
				{
					return true;
				}
				else if (searchedElement < array[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}

			return false;
		}


		private bool NaiveSearchAlgorithm(int[] array, int searchedElement)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == searchedElement)
				{
					return true;
				}
			}

			return false;
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool ArrayBinarySearch()
		{
			return Array.BinarySearch(MyArray, SearchedElement) > 0;
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool ArrayExists()
		{
			return Array.Exists(MyArray, x => x == SearchedElement);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool LinqContains()
		{
			return MyArray.Contains(SearchedElement);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool LinqAny()
		{
			return MyArray.Any(x => x == SearchedElement);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool LinqFirstOrDefault()
		{
			return MyArray.FirstOrDefault(x => x == SearchedElement) == SearchedElement;
		}
	}
}
