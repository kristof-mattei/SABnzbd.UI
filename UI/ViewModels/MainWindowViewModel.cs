namespace UI.ViewModels
{
	using Model;

	public sealed class MainWindowViewModel : ViewModelBase
	{
		public MainWindowViewModel()
		{
			if (App.IsInDesignMode())
			{
				this.Queue = new Queue()
				{
					ApiPaused = "Paused",
					KbPerSecond = 400,
					Slots = new[]
					{
						new Slot()
						{
							Index = 1, Status = "Downloading",
							FileName = "Linux Mint",
						},
						new Slot()
						{
							Index = 1, Status = "Downloading",
							FileName = "Ubunto Linux",
						},
						new Slot()
						{
							Index = 1, Status = "Paused",
							FileName = "Gentoo",
						}
						,
					}
				};
			}
		}

		public Queue Queue { get; set; }
	}
}