namespace Model
{
	using System.Diagnostics;
	using System.Xml.Serialization;

	[XmlRoot("queue")]
	public class Queue
	{
		#region "These are for the serializer, don't use them directly, they're not useful"

		[XmlElement("paused")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[UsedImplicitly]
		public string ApiPaused;

		#endregion

		/// <summary>
		/// TODO check type on this one and whether we need a custom backing field
		/// Represents the current speed
		/// </summary>
		[XmlElement("speed")]
		public decimal Speed { get; set; }

		/// <summary>
		///     Paused or not, uses the <see cref="ApiPaused" />
		/// </summary>
		public bool Paused
		{
			get
			{
				return this.ApiPaused == "True";
			}
		}

		[XmlArray("slots")]
		[XmlArrayItem(typeof (Slot), ElementName = "slot")]
		public Slot[] Slots { get; set; }
	}
}