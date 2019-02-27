using BenchmarkDotNet.Attributes;

namespace Benchmarks.Fun
{
	public class KeyCompareBenchmarks
	{
		[Params(new[] { 'A', 'b', 'b', 'c', 'c', 'D', 'D', 'I', 'o', 'n' })]
		public char[] SecretPassword;


		[Params(new[] { 'a', 'b', 'b', 'c', 'c', 'D', 'D', 'I', 'o', 'n' }, new[] { 'A', 'b', 'b', 'c', 'c', 'D', 'D', 'I', 'o', 'm' })]
		public char[] EnteredPassword;


		[Benchmark]
		public bool IsEqual()
		{
			return IsEqual(SecretPassword, EnteredPassword);
		}

		[Benchmark]
		public bool Safe()
		{
			return SafeCompare(SecretPassword, EnteredPassword);
		}

		private bool SafeCompare(char[] a, char[] b)
		{
			int mismatch = 0;

			for (var i = 0; i < a.Length; ++i)
			{
				mismatch |= a[i] ^ b[i];
			}

			return mismatch == 0;
		}

		private bool IsEqual(char[] a, char[] b)
		{
			for (var i = 0; i < a.Length; ++i)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}

			return true;
		}
	}
}
