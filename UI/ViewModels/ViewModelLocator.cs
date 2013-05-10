namespace UI.ViewModels
{
	using System.Collections.Generic;

	public class ViewModelLocator
	{
		public ViewModelLocator
			()
		{
			this.ViewModels = new Dictionary<string, object>
			{
				{
					typeof (MainWindowViewModel).Name, new MainWindowViewModel()
				},
				// {
				//	  "typeof(Foo)", new Foo()
				// }
			};
		}

		public Dictionary<string, object> ViewModels { get; set; }
	}
}