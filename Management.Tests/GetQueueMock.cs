namespace Management.Tests
{
	using System.Threading.Tasks;
	using Model;

	internal class GetQueueMock : IGetQueue
	{
		public Task<Queue> GetQueue(Queue queue)
		{
			return null;
		}
	}
}