namespace Management
{
	using Model;

	public interface IGetQueue
	{
		/// <summary>
		///     Pass in a Queue object to update that object to the latest values
		/// </summary>
		/// <param name="queue">A current constructed queue or null</param>
		/// <returns>An updated queue</returns>
		Queue UpdateQueue(Queue queue);	
		
		
		/// <summary>
		///     Gets the current queue (new object)
		/// </summary>
		/// <returns>An ueue</returns>
		Queue GetQueue();
	}
}