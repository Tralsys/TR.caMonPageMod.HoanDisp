using System.Windows;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	public class HoanLamp : Control
	{
		static public readonly DependencyProperty IsLightingProperty = DependencyProperty.Register(nameof(IsLighting), typeof(bool), typeof(HoanLamp));
		public bool IsLighting { get => (bool)GetValue(IsLightingProperty); set => SetValue(IsLightingProperty, value); }

		static public readonly DependencyProperty ContentProperty = DependencyProperty.Register(nameof(Content), typeof(UIElement), typeof(HoanLamp));
		public UIElement Content { get => (UIElement)GetValue(ContentProperty); set => SetValue(ContentProperty, value); }

		static public readonly DependencyProperty LightShadowSizeProperty = DependencyProperty.Register(nameof(LightShadowSize), typeof(double), typeof(HoanLamp));
		public double LightShadowSize { get => (double)GetValue(LightShadowSizeProperty); set => SetValue(LightShadowSizeProperty, value); }

		static public readonly DependencyProperty LightShadowOpacityProperty = DependencyProperty.Register(nameof(LightShadowOpacity), typeof(double), typeof(HoanLamp));
		public double LightShadowOpacity { get => (double)GetValue(LightShadowOpacityProperty); set => SetValue(LightShadowOpacityProperty, value); }


		static HoanLamp()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(HoanLamp), new FrameworkPropertyMetadata(typeof(HoanLamp)));
		}

	}
}
