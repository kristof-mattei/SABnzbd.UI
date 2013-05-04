namespace Management.Tests
{
	using Model;

	internal class GetQueueMock : IGetQueue
	{
		/// <summary>
		///     Pass in a Queue object to update that object to the latest values
		/// </summary>
		/// <param name="queue">A current constructed queue</param>
		/// <returns>An new or updated queue</returns>
		public void UpdateQueue(Queue queue)
		{
		}
	}
}