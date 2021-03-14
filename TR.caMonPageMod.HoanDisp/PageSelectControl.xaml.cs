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

		public PageSelectControl(TopPage tp)
		{
			TP = tp;
			InitializeComponent();
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
