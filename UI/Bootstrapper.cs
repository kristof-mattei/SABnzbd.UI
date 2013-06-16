namespace UI
{
	using System;
	using Properties;
	using ViewModels;

	public class Bootstrapper
	{
		public Bootstrapper()
		{
	

		}

		public void Start()
		{
			this.ViewModelLocator = new ViewModelLocator();

			// set up the API
			ApiReader = new ApiReader()
			{
				Url = Settings.Default.Url,
				ApiKey = Settings.Default.ApiKey,
			};

		}

		/// <summary>
		/// Static reference to the Api reader, viewmodels need to register here
		/// </summary>
		public static ApiReader ApiReader { get; private set; }

		public ViewModelLocator ViewModelLocator { get; set; }

		// this class contains all the code that runs in the background
		// it always runs

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
	}

	public class ApiReader
	{
		public Uri Url { get; set; }
		public string ApiKey { get; set; }
	}
}