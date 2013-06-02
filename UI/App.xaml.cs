using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;

namespace UI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
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
