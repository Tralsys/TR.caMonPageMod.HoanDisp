using System;
using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_ATSP_Sn.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_ATSP_Sn : UserControl
	{
		public Page_ATSP_Sn(HoanLampState hls)
		{
			DataContext = hls;
			InitializeComponent();

		}
	}
}
