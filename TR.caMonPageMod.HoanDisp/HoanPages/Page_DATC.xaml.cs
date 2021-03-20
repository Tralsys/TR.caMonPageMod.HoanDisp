using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_DATC.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_DATC : UserControl
	{
		public Page_DATC(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();
		}
	}
}
