namespace Management
{
	using Model;

	public class QueueManagement : IQueueManagement
	{
		public async void UpdateQueue(Queue queue)
		{
			Queue latestQueue;
			using (Connector c = new Connector())
			{
				latestQueue = await c.DownloadQueue();
			}

			this.UpdateQueueWith(queue ?? new Queue(), latestQueue);
		}

		private void UpdateQueueWith(Queue currentQueue, Queue latestQueue)
		{
			// we now want to update all the values of currentQueue with the values of latest queue
		}
	}
}