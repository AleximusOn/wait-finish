using NUnit.Framework;
using WaitFinish.Common;
using System.Threading.Tasks;

using System;
using System.Collections;

namespace WaitFinish.Tests
{
	public class Tests
	{
		[TestCaseSource(typeof(Test1Sources))]
		public async Task Test1(int delay)
		{
			var tst = new TestedClass();
			await tst.DoSomething(delay);
		}

		public class Test1Sources : IEnumerable
		{
			private Random _rnd;
			public Test1Sources()
			{
				_rnd = new Random();
			}

			public IEnumerator GetEnumerator()
			{
				for (var i = 0; i < 19; i++)
				{
					yield return new[] { _rnd.Next(100) * 10 };
				}
			}
		}
	}
}