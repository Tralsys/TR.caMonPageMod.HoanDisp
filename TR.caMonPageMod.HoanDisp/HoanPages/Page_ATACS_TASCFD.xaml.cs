using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_ATACS_TASCFD.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_ATACS_TASCFD : UserControl
	{
		public Page_ATACS_TASCFD(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();
		}
	}
}
