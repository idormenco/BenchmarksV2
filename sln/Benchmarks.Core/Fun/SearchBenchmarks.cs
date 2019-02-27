using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Core.Fun
{
	public class SearchBenchmarks
	{
		public int[] MyArray = new[] { 1, 2, 4, 7, 11, 15, 19, 22, 44, 99, 100, 134, 150, 666 };

		private const int Size = 14; 

		[Params(1, 150)]
		public int SearchedElement;


		[Benchmark(OperationsPerInvoke = Size)]
		public bool IonsSearch()
		{
			return IonsAlgorithm(MyArray, SearchedElement);
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


		private bool IonsAlgorithm(int[] array, int searchedElement)
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
		public bool LinqSearch()
		{
			return MyArray.Contains(SearchedElement);
		}

		[Benchmark(OperationsPerInvoke = Size)]
		public bool ArrayBinarySearch()
		{
			return Array.BinarySearch(MyArray,SearchedElement)>0;
		}
	}
}
