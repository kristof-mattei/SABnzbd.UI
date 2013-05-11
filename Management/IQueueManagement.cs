namespace Management
{
	using System.Threading.Tasks;
	using Model;

	public interface IQueueManagement
	{

		/// <summary>
		///     Pass in a Queue object to update that object to the latest values
		/// </summary>
		/// <param name="queue">A current constructed queue</param>
		/// <returns>An new or updated queue</returns>
		void UpdateQueue(Queue queue);
	}
}