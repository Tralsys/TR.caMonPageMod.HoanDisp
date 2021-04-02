using BIDSDataUpdateNotifier.LampStateProvider;

namespace TR.caMonPageMod.HoanDisp
{
	public class HoanLampState
	{
		public ATACSLamps ATACS { get; } = new();
		public ATSPLamps ATSP { get; } = new();
		public ATSSnLamps ATSSn { get; } = new();
		public DATCLamps DATC { get; } = new();
		public FDLamps FD { get; } = new();
		public TASCLamps TASC { get; } = new();
	}
}
