using System.Windows.Controls;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>
	/// Page_ATSP.xaml の相互作用ロジック
	/// </summary>
	public partial class Page_ATSP : UserControl
	{
		//HoanLampState HLampState { get; }
		public Page_ATSP(HoanLampState hlstate)
		{
			DataContext = hlstate;
			InitializeComponent();
		}
	}
}
