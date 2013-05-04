namespace Management
{
	using System;
	using System.Net;
	using System.Threading.Tasks;
	using Model;

	internal class Connector : IDisposable
	{
		public void Dispose()
		{
			// cleanup on isle 4
		}

		public async Task<Queue> DownloadQueue()
		{
			string result;

			using (WebClient w = new WebClient())
			{
				result = await w.DownloadStringTaskAsync("http://localhost:8080/sabnzbd/api?mode=queue&output=xml");
			}

			return this.ConvertApiResultToQueue(result);
		}

		private Queue ConvertApiResultToQueue(string apiResult)
		{
			return new Queue();
		}
	}
}