namespace Management
{
	using System;
	using System.IO;
	using System.Net;
	using System.Text;
	using System.Threading.Tasks;
	using System.Xml.Serialization;
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

			XmlSerializer xmlSerializer = new XmlSerializer(typeof (Queue));

			return (Queue)xmlSerializer.Deserialize(new StringReader(apiResult));
		}
	}
}