namespace Model
{
	using System.Xml.Serialization;

	[UsedImplicitly]
	[XmlType("slot")]
	public class Slot
	{
		[XmlElement("status", Type = typeof(string))]
		public string Status { get; set; }

		[XmlElement("index", Type = typeof(int))]
		public int Index { get; set; }

		[XmlElement("filename", Type = typeof(string))]
		public string FileName { get; set; }
	}
}