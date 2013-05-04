namespace Management.Tests
{
	using Model;

	internal class GetQueueMock : IGetQueue
	{
		public Queue UpdateQueue(Queue queue)
		{
			queue = ApplyUpdates(queue);

			return queue;
		}

		public Queue GetQueue()
		{
			return new Queue();
		}

		private Queue ApplyUpdates(Queue queue)
		{
			// queue.Foo = "Bar"...

			return queue;
		}

		
	}
}