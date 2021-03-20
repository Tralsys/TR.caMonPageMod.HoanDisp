using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_DATC_TASCFD.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_DATC_TASCFD : UserControl
	{
		public Page_DATC_TASCFD(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();
		}
	}
}
