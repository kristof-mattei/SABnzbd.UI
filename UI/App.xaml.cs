namespace UI
{
	using System;
	using System.ComponentModel;
	using System.Windows;

	/// <summary>
	///     Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		[STAThread]
		public static void Main()
		{
			// TODO handle single instance here & also handle Windows 7 thingies (how you call them... ? )
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}

		public App()
		{
			Bootstrapper b = new Bootstrapper();

			b.Start();
		}


		public static bool IsInDesignMode()
		{
			return DesignerProperties.GetIsInDesignMode(new DependencyObject());
		}
	}
}