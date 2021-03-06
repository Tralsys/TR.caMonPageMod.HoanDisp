using System.Windows;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// PageSelectControl.xaml の相互作用ロジック
	/// </summary>
	public partial class PageSelectControl : UserControl
	{
		internal TopPage TP { get; }
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

				case "ATS-P/Sn":
					TP.ChangeThePage(new Page_ATSP_Sn(HLampState));
					break;

				case "ATS-P + TASC/FD":
					TP.ChangeThePage(new Page_ATSP_TASCFD(HLampState));
					break;

				case "ATS-P/Sn + TASC/FD":
					TP.ChangeThePage(new Page_ATSP_Sn_TASCFD(HLampState));
					break;

				case "D-ATC":
					TP.ChangeThePage(new Page_DATC(HLampState));
					break;

				case "D-ATC + TASC/FD":
					TP.ChangeThePage(new Page_DATC_TASCFD(HLampState));
					break;

				case "ATACS":
					TP.ChangeThePage(new Page_ATACS(HLampState));
					break;

				case "ATACS + TASC/FD":
					TP.ChangeThePage(new Page_ATACS_TASCFD(HLampState));
					break;

			}
		}

		private void GoSettingPushed(object sender, RoutedEventArgs e) => TP.ChangeThePage(new SettingPage(HLampState, this));
		private void Change1610ModePushed(object sender, RoutedEventArgs e) => TP.Is1610Mode = !TP.Is1610Mode;
	}
}
