namespace UI.ViewModels
{
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using Management;
	using Model;

	public sealed class MainWindowViewModel : INotifyPropertyChanged
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

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}