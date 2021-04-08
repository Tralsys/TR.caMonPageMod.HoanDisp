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
		bool _Is1610Mode = true;
		internal bool Is1610Mode
		{
			get => _Is1610Mode;
			set
			{
				if (Is1610Mode != value)
				{
					_Is1610Mode = value;

					if (MainViewBox.Child is Control c)
						SetContentWidth(c);
				}
			}
		}
		void SetContentWidth(Control c) => c.Width = Is1610Mode ? 960 : 800;
		
		public TopPage(caMonIF camonif)
		{
			CamonIF = camonif;
			InitializeComponent();
			ChangeThePage(new PageSelectControl(this));
		}

		private void GoToSelectPage(object sender, RoutedEventArgs e)
			=> ChangeThePage(new PageSelectControl(this));

		internal void ChangeThePage(UIElement elem)
		{
			MainViewBox.Child = elem;
			if (elem is Control c)
			{
				c.FontFamily = this.FontFamily;
				SetContentWidth(c);
			}
		}
	}
}
