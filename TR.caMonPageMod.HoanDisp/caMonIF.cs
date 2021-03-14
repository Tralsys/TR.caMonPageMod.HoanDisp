using System;
using System.Windows.Controls;

using caMon;

namespace TR.caMonPageMod.HoanDisp
{
	public class caMonIF : IPages
	{
		public Page FrontPage { get; }

		public event EventHandler BackToHome;
		public event EventHandler CloseApp;
		static private readonly EventArgs EvA = new EventArgs();
		internal void BackToHomeDo() => BackToHome?.Invoke(this, EvA);
		internal void CloseAppDo() => CloseApp?.Invoke(this, EvA);

		public caMonIF()
		{
			FrontPage = new TopPage(this);
		}
		public void Dispose()
		{
			
		}
	}
}
