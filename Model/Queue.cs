namespace Model
{
	using System.Collections.ObjectModel;
	using System.Xml.Serialization;

	[XmlRoot("queue")]
	public class Queue
	{
		/// <summary>
		///     Implemented as True or False on the Api, so that's easily convertible
		/// </summary>
		[XmlElement("paused")]
		public bool Paused { get; set; }

		[XmlArray("slots")]
		[XmlArrayItem(typeof(Slot), ElementName = "slot")]
		public Slot[] Slots { get; set; }
	}
}