namespace Management.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Mocks;

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			QueueManagementMock c = new QueueManagementMock();

			Assert.AreEqual(c, c);
		}
	}
}