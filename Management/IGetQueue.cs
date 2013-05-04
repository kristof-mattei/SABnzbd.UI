namespace Management
{
	using System.Threading.Tasks;
	using Model;

	public interface IGetQueue
	{

		/// <summary>
		///     Pass in a Queue object to update that object to the latest values
		///		or null to get a new queue
		/// </summary>
		/// <param name="queue">A current constructed queue or null</param>
		/// <returns>An new or updated queue</returns>
		Task<Queue> GetQueue(Queue queue);
	}
}