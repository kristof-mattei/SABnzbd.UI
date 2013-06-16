namespace UI.ViewModels
{
	public class ViewModelLocator
	{
		public ViewModelLocator()
		{
			this.MainWindowViewModel = new MainWindowViewModel();
			// ...
			// ...
			// TODO add extra viewmodels here
		}

		public MainWindowViewModel MainWindowViewModel { get; private set; }
	}
}