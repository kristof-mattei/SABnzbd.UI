namespace UI.ViewModels
{
	using System.Timers;
	using Management;
	using Management.Mocks;
	using Model;
	using Properties;

	public sealed class MainWindowViewModel : ViewModelBase
	{
		private readonly Queue _queue = new Queue();
		private readonly IQueueManagement _queueManagement;

		public MainWindowViewModel()
		{
			this._queueManagement = this.InDesignMode ? (IQueueManagement) new QueueManagementMock() : new QueueManagement();

			// fire initial time (timer waits for interval until it fires)
			this.UpdateQueue();

			// start timer
			Timer t = new Timer(Settings.Default.UpdateInterval) { AutoReset = true };

			t.Elapsed += (sender, e) => this.UpdateQueue();

			t.Start();
		}

		public Queue Queue
		{
			get
			{
				return this._queue;
			}

			// no setter needed
		}

		private void UpdateQueue()
		{
			this._queueManagement.UpdateQueue(this._queue);
		}
	}
}