using NUnit.Framework;

namespace WaitFinish.Tests
{
	[TestFixture]
	public class NegativeTests
	{
		[Test]
		public void NegativeTest()
		{
			Assert.AreEqual(true, false);
		}
	}
}
