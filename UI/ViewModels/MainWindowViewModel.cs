namespace UI.ViewModels
{
	using Management;
	using Model;

	public class MainWindowViewModel
	{
		private readonly QueueManagement _queueManagement;
		private Queue _queue;

		public MainWindowViewModel()
		{
			this._queueManagement = new QueueManagement();
			this._queue = new Queue();

			this.LoadInitialQueue();
		}

		public Queue Queue
		{
			get
			{
				return this._queue;
			}
		}

		private async void LoadInitialQueue()
		{
			this._queue = await this._queueManagement.GetQueue(this.Queue);
		}
	}
}