namespace UI.ViewModels
{
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using System.Windows;
	using Model;

	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		protected ViewModelBase()
		{
			this.InDesignMode = DesignerProperties.GetIsInDesignMode(new DependencyObject());
		}

		protected bool InDesignMode { get; private set; }


		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}