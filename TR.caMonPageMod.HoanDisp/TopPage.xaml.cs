using System;
using System.Windows;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// TopPage.xaml の相互作用ロジック
	/// </summary>
	public partial class TopPage : Page
	{
		internal caMonIF CamonIF { get; }
		public TopPage(caMonIF camonif)
		{
			CamonIF = camonif;
			InitializeComponent();
			ChangeThePage(new PageSelectControl(this));
		}

		private void GoToSelectPage(object sender, RoutedEventArgs e)
			=> ChangeThePage(new PageSelectControl(this));

		internal void ChangeThePage(UIElement elem)
			=> MainViewBox.Child = elem;
	}
}
