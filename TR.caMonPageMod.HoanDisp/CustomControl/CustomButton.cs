using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace TR.caMonPageMod.HoanDisp
{
	public class CustomButton : Button
	{
		#region Light/Shadow Properties
		static public readonly DependencyProperty LightShadowSizeProperty = DependencyProperty.Register(nameof(LightShadowSize), typeof(double), typeof(CustomButton));
		public double LightShadowSize { get => (double)GetValue(LightShadowSizeProperty); set => SetValue(LightShadowSizeProperty, value); }

		static public readonly DependencyProperty LightShadowOpacityProperty = DependencyProperty.Register(nameof(LightShadowOpacity), typeof(double), typeof(CustomButton));
		public double LightShadowOpacity { get => (double)GetValue(LightShadowOpacityProperty); set => SetValue(LightShadowOpacityProperty, value); }
		#endregion

		static public readonly DependencyProperty PushedBackgroundProperty = DependencyProperty.Register(nameof(PushedBackground), typeof(Brush), typeof(CustomButton));
		public Brush PushedBackground { get => (Brush)GetValue(PushedBackgroundProperty); set => SetValue(PushedBackgroundProperty, value); }

		static public readonly DependencyProperty PushedForegroundProperty = DependencyProperty.Register(nameof(PushedForeground), typeof(Brush), typeof(CustomButton));
		public Brush PushedForeground { get => (Brush)GetValue(PushedForegroundProperty); set => SetValue(PushedForegroundProperty, value); }


		#region Blink function Properties
		static public readonly DependencyProperty IsBlinkingProperty = DependencyProperty.Register(nameof(IsBlinking), typeof(bool), typeof(CustomButton));
		public bool IsBlinking { get => (bool)GetValue(IsBlinkingProperty); set => SetValue(IsBlinkingProperty, value); }

		static public readonly DependencyProperty BlinkBackgroundProperty = DependencyProperty.Register(nameof(BlinkBackground), typeof(Brush), typeof(CustomButton));
		public Brush BlinkBackground { get => (Brush)GetValue(BlinkBackgroundProperty); set => SetValue(BlinkBackgroundProperty, value); }

		static public readonly DependencyProperty BlinkForegroundProperty = DependencyProperty.Register(nameof(BlinkForeground), typeof(Brush), typeof(CustomButton));
		public Brush BlinkForeground { get => (Brush)GetValue(BlinkForegroundProperty); set => SetValue(BlinkForegroundProperty, value); }

		static public readonly DependencyProperty BlinkProviderInstanceProperty = DependencyProperty.Register(nameof(BlinkProviderInstance), typeof(BlinkProvider), typeof(CustomButton), new PropertyMetadata(BlinkProviderChangedCallback));
		public BlinkProvider BlinkProviderInstance { get => (BlinkProvider)GetValue(BlinkProviderInstanceProperty); set => SetValue(BlinkProviderInstanceProperty, value); }

		static public readonly DependencyProperty BlinkStateProperty = DependencyProperty.Register(nameof(BlinkState), typeof(bool), typeof(CustomButton));
		public bool BlinkState { get => (bool)GetValue(BlinkStateProperty); set => SetValue(BlinkStateProperty, value); }

		static private void BlinkProviderChangedCallback(DependencyObject s, DependencyPropertyChangedEventArgs e)
		{
			if(s is CustomButton cb)
			{
				Binding b = new(nameof(BlinkProvider.BlinkState));
				b.Source = e.NewValue;
				cb.SetBinding(BlinkStateProperty, b);
			}
		}
		#endregion

		static CustomButton() => DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomButton), new FrameworkPropertyMetadata(typeof(CustomButton)));

		public override void EndInit()
		{
			base.EndInit();
			BlinkProviderInstance ??= new();
		}
	}
}
