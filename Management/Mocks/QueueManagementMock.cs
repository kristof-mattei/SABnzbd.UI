namespace Management.Mocks
{
	using Model;

	public class QueueManagementMock : IQueueManagement
	{
		/// <summary>
		///     Pass in a Queue object to update that object to the latest values
		/// </summary>
		/// <param name="queue">A current constructed queue</param>
		/// <returns>An new or updated queue</returns>
		public void UpdateQueue(Queue queue)
		{
			queue.ApiPaused = "True";
			queue.KbPerSecond = 555.55m;
		}
	}
}