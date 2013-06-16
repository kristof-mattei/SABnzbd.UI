namespace UI
{
	using System;
	using System.Windows;

	/// <summary>
	///     Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		[STAThread]
		public static void Main()
		{
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}

////this._queueManagement = this.InDesignMode ? (IQueueManagement) new QueueManagementMock() : new QueueManagement();
//	private readonly IQueueManagement _queueManagement;
//	if (this.InDesignMode)
//		return;

//	this._queueManagement = new QueueManagement();

//	// fire initial time (timer waits for interval until it fires)
//	this.UpdateQueue();

//	// start timer
//	Timer t = new Timer(Settings.Default.UpdateInterval) { AutoReset = true };

//	t.Elapsed += (sender, e) => this.UpdateQueue();

//	t.Start();
//public Queue Queue
//{
//	get
//	{
//		return this._queue;
//	}

//	// no setter needed
//}

//private void UpdateQueue()
//{
//	this._queueManagement.UpdateQueue(this._queue);
//}