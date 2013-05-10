namespace Model
{
	using System.Diagnostics;
	using System.Xml.Serialization;

	[XmlRoot("queue")]
	public class Queue
	{
		#region These are for the serializer, don't use them directly, they're not useful

		[XmlElement("paused")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[UsedImplicitly]
		public string ApiPaused;

		#endregion

		#region Direct API translations

		/// <summary>
		///     Represents the current speed
		/// </summary>
		[XmlElement("kbpersec")]
		public decimal KbPerSecond { get; set; }

		#endregion

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

		#region Children

		[XmlArray("slots")]
		[XmlArrayItem(typeof (Slot), ElementName = "slot")]
		public Slot[] Slots { get; set; }

		#endregion
	}
}