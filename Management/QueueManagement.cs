namespace Management
{
	using System;
	using System.Threading.Tasks;
	using Model;

	public class QueueManagement : IGetQueue
	{
		public async Task<Queue> GetQueue(Queue queue = null)
		{
			await this.UpdateQueue(queue);

			return queue;
		}

		/// <summary>
		/// Updates the current queue with the new values
		/// </summary>
		/// <param name="queue">The old queue</param>
		/// <returns>A stupid task, because I cannot await void</returns>
		private async Task UpdateQueue(Queue queue)
		{
			Queue latestQueue = await this.GetLatestQueue();

			this.UpdateQueueWith(queue, latestQueue);
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

	internal class Connector : IDisposable
	{
		public void Dispose()
		{
			// cleanup on isle 4
		}

		public async Task<Queue> DownloadQueue()
		{
			await Task.Delay(500);

			// TODO download queue

			return new Queue();
		}
	}
}