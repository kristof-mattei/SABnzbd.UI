namespace UI.Controls
{
	using System;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Controls.Primitives;

	/// <summary>
	///     Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	///     Step 1a) Using this custom control in a XAML file that exists in the current project.
	///     Add this XmlNamespace attribute to the root element of the markup file where it is
	///     to be used:
	///     xmlns:MyNamespace="clr-namespace:UI.Controls"
	///     Step 1b) Using this custom control in a XAML file that exists in a different project.
	///     Add this XmlNamespace attribute to the root element of the markup file where it is
	///     to be used:
	///     xmlns:MyNamespace="clr-namespace:UI.Controls;assembly=UI.Controls"
	///     You will also need to add a project reference from the project where the XAML file lives
	///     to this project and Rebuild to avoid compilation errors:
	///     Right click on the target project in the Solution Explorer and
	///     "Add Reference"->"Projects"->[Browse to and select this project]
	///     Step 2)
	///     Go ahead and use your control in the XAML file.
	///     <MyNamespace:IsDownloading />
	/// </summary>
	[TemplatePart(Name = "Part_Toggle", Type = typeof (ToggleButton))]
	public class IsDownloading : Control
	{
		public static readonly DependencyProperty IsPausedProperty =
			DependencyProperty.Register("IsPaused", typeof (bool), typeof (IsDownloading), new PropertyMetadata(false));

		private ToggleButton _toggleButton;

		static IsDownloading()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof (IsDownloading), new FrameworkPropertyMetadata(typeof (IsDownloading)));
		}

		public bool IsPaused
		{
			get
			{
				return (bool) this.GetValue(IsPausedProperty);
			}
			set
			{
				this.SetValue(IsPausedProperty, value);

				if (value)
				{
					// paused
					// -> send notification to pause downloading
				}
				else
				{
					// downloading
					// -> send notification to start downloading
				}
			}
		}

		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this._toggleButton = this.Template.FindName("PART_ToggleButton", this) as ToggleButton;

			if (null == this._toggleButton)
			{
				throw new InvalidOperationException("Missing essential part in template");
			}
		}
	}
}