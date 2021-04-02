using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_ATSP_Sn_TASCFD.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_ATSP_Sn_TASCFD : UserControl
	{
		public Page_ATSP_Sn_TASCFD(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();
		}
	}
}
