namespace Management
{
	using System;
	using System.IO;
	using System.Net;
	using System.Threading.Tasks;
	using System.Xml.Serialization;
	using Model;

	internal class Connector : IDisposable
	{
		public void Dispose()
		{
			// cleanup on isle 4
		}

		~Connector()
		{
			// cleanup	
		}

		public async Task<Queue> DownloadQueue()
		{
			using (WebClient w = new WebClient())
			{
				return this.ConvertApiResultToQueue(await w.DownloadStringTaskAsync("http://localhost:8080/sabnzbd/api?mode=queue&output=xml"));
			}
		}

		private Queue ConvertApiResultToQueue(string apiResult)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof (Queue));

			return (Queue) xmlSerializer.Deserialize(new StringReader(apiResult));
		}
	}
}