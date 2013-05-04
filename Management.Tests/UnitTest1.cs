namespace Management.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			GetQueueMock c = new GetQueueMock();

			Assert.AreEqual(c, c);
		}
	}
}