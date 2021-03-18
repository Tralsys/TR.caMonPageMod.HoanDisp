using System.Windows;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// PageSelectControl.xaml の相互作用ロジック
	/// </summary>
	public partial class PageSelectControl : UserControl
	{
		TopPage TP { get; }
		static HoanLampState HLampState { get; } = new HoanLampState();

		static readonly string CopyrightNotice_Font = @"本Modでは表示フォントに「源柔ゴシック」(http://jikasei.me/font/genjyuu/) を使用しています。
Licensed under SIL Open Font License 1.1 (http://scripts.sil.org/OFL)
© 2015 自家製フォント工房, © 2014, 2015 Adobe Systems Incorporated, © 2015 M+ FONTS PROJECT";

		public PageSelectControl(TopPage tp)
		{
			TP = tp;
			InitializeComponent();
			CopyrightTB.Text = CopyrightNotice_Font;
		}

		private void GoHomePushed(object sender, RoutedEventArgs e) => TP.CamonIF.BackToHomeDo();

		private void ClosePushed(object sender, RoutedEventArgs e) => TP.CamonIF.CloseAppDo();

		private void SelButonClicked(object sender, RoutedEventArgs e)
		{
			switch((sender as Button)?.Content as string)
			{
				case "ATS-P":
					TP.ChangeThePage(new Page_ATSP(HLampState));
					break;
			}
		}
	}
}
