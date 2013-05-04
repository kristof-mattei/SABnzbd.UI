namespace UI.ViewModels
{
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using Management;
	using Model;

	public sealed class MainWindowViewModel : INotifyPropertyChanged
	{
		private readonly QueueManagement _queueManagement = new QueueManagement();
		private Queue _queue = new Queue();

		public Queue Queue
		{
			get
			{
				// make sure when the user asks for a queue he gets an updated one
				this.UpdateQueue();
				return this._queue;
			}
			private set
			{
				if (Equals(value, this._queue))
				{
					return;
				}
				this._queue = value;
				this.OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void UpdateQueue()
		{
			this._queueManagement.UpdateQueue(this.Queue);
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = this.PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}