namespace Model
{
	using System.Collections.ObjectModel;

	// TODO add correct attribute (it's name is 'queue' in the XML).
	public class Queue
	{
		
		public bool Paused { get; set; }

		public ObservableCollection<Slot> Slots { get; set; }
	}
}