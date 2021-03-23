using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_ATACS.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_ATACS : UserControl
	{
		public Page_ATACS(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();
		}
	}
}
