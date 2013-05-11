namespace UI.ViewModels
{
	using System.ComponentModel;
	using Management;
	using Management.Mocks;
	using Model;

	public sealed class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
	{
		private readonly Queue _queue = new Queue();
		private readonly IQueueManagement _queueManagement;

		public MainWindowViewModel ()
		{
			this._queueManagement = this.InDesignMode ? (IQueueManagement) new QueueManagementMock() : new QueueManagement();

			// construct initial queue
			this.UpdateQueue();
		}

		public Queue Queue
		{
			get
			{
				return this._queue;
			}
		}

		private void UpdateQueue()
		{
			this._queueManagement.UpdateQueue(this._queue);
		}
	}
}