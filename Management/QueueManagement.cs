namespace Management
{
	using System.Threading.Tasks;
	using Model;

	public class QueueManagement : IGetQueue
	{
		public async void UpdateQueue(Queue queue)
		{
			Queue latestQueue = await this.GetLatestQueue();

			this.UpdateQueueWith(queue ?? new Queue(), latestQueue);
		}

		private void UpdateQueueWith(Queue currentQueue, Queue latestQueue)
		{
			// we now want to update all the values of currentQueue with the values of latest queue
		}

		private async Task<Queue> GetLatestQueue()
		{
			using (Connector c = new Connector())
			{
				return await c.DownloadQueue();
			}
		}
	}
}