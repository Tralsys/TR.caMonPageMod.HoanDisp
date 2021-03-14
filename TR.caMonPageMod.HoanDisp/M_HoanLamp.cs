using System.Windows;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	public class M_HoanLamp : Control
	{
		static public readonly DependencyProperty IsLightingProperty = DependencyProperty.Register(nameof(IsLighting), typeof(bool), typeof(M_HoanLamp));
		public bool IsLighting { get => (bool)GetValue(IsLightingProperty); set => SetValue(IsLightingProperty, value); }

		static public readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(M_HoanLamp));
		public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }


		static M_HoanLamp()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(M_HoanLamp), new FrameworkPropertyMetadata(typeof(M_HoanLamp)));
		}

	}
}
