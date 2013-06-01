namespace Management
{
	using System;
	using Model;

	public class QueueManagement : IQueueManagement
	{
		public async void UpdateQueue([NotNull] Queue queue)
		{
			if (queue == null)
			{
				throw new ArgumentNullException("queue");
			}

			Queue latestQueue;
			using (Connector c = new Connector())
			{
				latestQueue = await c.DownloadQueue();
			}

			this.UpdateQueueWith(queue, latestQueue);
		}

		private void UpdateQueueWith([NotNull] Queue currentQueue, [NotNull] Queue latestQueue)
		{
			if (currentQueue == null)
			{
				throw new ArgumentNullException("currentQueue");
			}
			if (latestQueue == null)
			{
				throw new ArgumentNullException("latestQueue");
			}
			// we now want to update all the values of currentQueue with the values of latest queue
		}
	}
}