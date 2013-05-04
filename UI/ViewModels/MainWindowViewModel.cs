namespace UI.ViewModels
{
	using Management;
	using Model;

	public sealed class MainWindowViewModel
	{
		private readonly Queue _queue = new Queue();
		private readonly QueueManagement _queueManagement = new QueueManagement();

		public Queue Queue
		{
			get
			{
				// make sure when the user asks for a queue he gets an updated one
				this.UpdateQueue();
				return this._queue;
			}
		}

		private void UpdateQueue()
		{
			this._queueManagement.UpdateQueue(this._queue);
		}
	}
}