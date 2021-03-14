using System.ComponentModel;

namespace TR.caMonPageMod.HoanDisp
{
	public class HoanLampState : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		void propertyChanged(in string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		#region ATS-P
		bool _ATS_P;
		public bool ATS_P { get => _ATS_P; set { _ATS_P = value; propertyChanged(nameof(ATS_P)); } }

		bool _P_Dengen;
		public bool P_Dengen { get => _P_Dengen; set { _P_Dengen = value; propertyChanged(nameof(P_Dengen)); } }

		bool _Pattern_Sekkin;
		public bool Pattern_Sekkin { get => _Pattern_Sekkin; set { _Pattern_Sekkin = value; propertyChanged(nameof(Pattern_Sekkin)); } }

		bool _Joyo_Brake;
		public bool Joyo_Brake { get => _Joyo_Brake; set { _Joyo_Brake = value; propertyChanged(nameof(Joyo_Brake)); } }

		bool _Hijo_Brake;
		public bool Hijo_Brake { get => _Hijo_Brake; set { _Hijo_Brake = value; propertyChanged(nameof(Hijo_Brake)); } }

		bool _Brake_Kaihou;
		public bool Brake_Kaihou { get => _Brake_Kaihou; set { _Brake_Kaihou = value; propertyChanged(nameof(Brake_Kaihou)); } }

		bool _P_Kosyo;
		public bool P_Kosyo { get => _P_Kosyo; set { _P_Kosyo = value; propertyChanged(nameof(P_Kosyo)); } }
		#endregion

		#region ATS-S
		bool _ATS_Dengen;
		public bool ATS_Dengen { get => _ATS_Dengen; set { _ATS_Dengen = value; propertyChanged(nameof(ATS_Dengen)); } }

		bool _ATS_Dousa;
		public bool ATS_Dousa { get => _ATS_Dousa; set { _ATS_Dousa = value; propertyChanged(nameof(ATS_Dousa)); } }
		#endregion

		#region TASC
		bool _TASC_Dengen;
		/// <summary>TASC OR TASC電源</summary>
		public bool TASC_Dengen { get => _TASC_Dengen; set { _TASC_Dengen = value; propertyChanged(nameof(TASC_Dengen)); } }
		bool _TASC_Pattern;
		/// <summary>TASCパターン OR TASC制御</summary>
		public bool TASC_Pattern { get => _TASC_Pattern; set { _TASC_Pattern = value; propertyChanged(nameof(TASC_Pattern)); } }
		bool _TASC_Brake;
		public bool TASC_Brake { get => _TASC_Brake; set { _TASC_Brake = value; propertyChanged(nameof(TASC_Brake)); } }
		bool _TASC_Off;
		public bool TASC_Off { get => _TASC_Off; set { _TASC_Off = value; propertyChanged(nameof(TASC_Off)); } }
		bool _TASC_Kosyo;
		public bool TASC_Kosyo { get => _TASC_Kosyo; set { _TASC_Kosyo = value; propertyChanged(nameof(TASC_Kosyo)); } }
		bool _Inching_SeigyoChu;
		public bool Inching_SeigyoChu { get => _Inching_SeigyoChu; set { _Inching_SeigyoChu = value; propertyChanged(nameof(Inching_SeigyoChu)); } }
		#endregion

		#region FD
		bool _Tei_Ichi;
		public bool Tei_Ichi { get => _Tei_Ichi; set { _Tei_Ichi = value; propertyChanged(nameof(Tei_Ichi)); } }
		bool _CarDoor_AllClosed;
		public bool CarDoor_AllClosed { get => _CarDoor_AllClosed; set { _CarDoor_AllClosed = value; propertyChanged(nameof(CarDoor_AllClosed)); } }
		bool _FD_AllClosed;
		public bool FD_AllClosed { get => _FD_AllClosed; set { _FD_AllClosed = value; propertyChanged(nameof(FD_AllClosed)); } }
		bool _FD_Renkei;
		public bool FD_Renkei { get => _FD_Renkei; set { _FD_Renkei = value; propertyChanged(nameof(FD_Renkei)); } }
		bool _FD_Bunri;
		public bool FD_Bunri { get => _FD_Bunri; set { _FD_Bunri = value; propertyChanged(nameof(FD_Bunri)); } }
		bool _FD_TendoBoshi_Brake;
		public bool FD_TendoBoshi_Brake { get => _FD_TendoBoshi_Brake; set { _FD_TendoBoshi_Brake = value; propertyChanged(nameof(FD_TendoBoshi_Brake)); } }
		#endregion

		#region D-ATC
		bool _Digital_ATC;
		public bool Digital_ATC { get => _Digital_ATC; set { _Digital_ATC = value; propertyChanged(nameof(Digital_ATC)); } }
		bool _ATC;
		public bool ATC { get => _ATC; set { _ATC = value; propertyChanged(nameof(ATC)); } }
		bool _DATC_Off;
		public bool DATC_Off { get => _DATC_Off; set { _DATC_Off = value; propertyChanged(nameof(DATC_Off)); } }
		bool _DATC_Pattern_Teigen;
		public bool DATC_Pattern_Teigen { get => _DATC_Pattern_Teigen; set { _DATC_Pattern_Teigen = value; propertyChanged(nameof(DATC_Pattern_Teigen)); } }
		bool _DATC_Hijo_Unten;
		public bool DATC_Hijo_Unten { get => _DATC_Hijo_Unten; set { _DATC_Hijo_Unten = value; propertyChanged(nameof(DATC_Hijo_Unten)); } }
		bool _DATC_Joyo;
		public bool DATC_Joyo { get => _DATC_Joyo; set { _DATC_Joyo = value; propertyChanged(nameof(DATC_Joyo)); } }
		bool _DATC_Hijo;
		public bool DATC_Hijo { get => _DATC_Hijo; set { _DATC_Hijo = value; propertyChanged(nameof(DATC_Hijo)); } }
		bool _DATC_TeitsuBoshi_Dousa;
		public bool DATC_TeitsuBoshi_Dousa { get => _DATC_TeitsuBoshi_Dousa; set { _DATC_TeitsuBoshi_Dousa = value; propertyChanged(nameof(DATC_TeitsuBoshi_Dousa)); } }
		bool _DATC_Power;
		public bool DATC_Power { get => _DATC_Power; set { _DATC_Power = value; propertyChanged(nameof(DATC_Power)); } }
		bool _DATC_Kaihou;
		public bool DATC_Kaihou { get => _DATC_Kaihou; set { _DATC_Kaihou = value; propertyChanged(nameof(DATC_Kaihou)); } }
		#endregion

		#region ATACS
		bool _ATACS_ShajoID_Kosho;
		public bool ATACS_ShajoID_Kosho { get => _ATACS_ShajoID_Kosho; set { _ATACS_ShajoID_Kosho = value; propertyChanged(nameof(ATACS_ShajoID_Kosho)); } }
		bool _ATACS;
		public bool ATACS { get => _ATACS; set { _ATACS = value; propertyChanged(nameof(ATACS)); } }
		bool _ATACS_Off;
		public bool ATACS_Off { get => _ATACS_Off; set { _ATACS_Off = value; propertyChanged(nameof(ATACS_Off)); } }
		bool _ATACS_Pattern_Teigen;
		public bool ATACS_Pattern_Teigen { get => _ATACS_Pattern_Teigen; set { _ATACS_Pattern_Teigen = value; propertyChanged(nameof(ATACS_Pattern_Teigen)); } }
		bool _ATACS_Hijo_Unten;
		public bool ATACS_Hijo_Unten { get => _ATACS_Hijo_Unten; set { _ATACS_Hijo_Unten = value; propertyChanged(nameof(ATACS_Hijo_Unten)); } }
		bool _ATACS_Joyo;
		public bool ATACS_Joyo { get => _ATACS_Joyo; set { _ATACS_Joyo = value; propertyChanged(nameof(ATACS_Joyo)); } }
		bool _ATACS_Hijo;
		public bool ATACS_Hijo { get => _ATACS_Hijo; set { _ATACS_Hijo = value; propertyChanged(nameof(ATACS_Hijo)); } }
		bool _ATACS_TeitsuBoshi_Dousa;
		public bool ATACS_TeitsuBoshi_Dousa { get => _ATACS_TeitsuBoshi_Dousa; set { _ATACS_TeitsuBoshi_Dousa = value; propertyChanged(nameof(ATACS_TeitsuBoshi_Dousa)); } }
		bool _ATACS_Dengen;
		public bool ATACS_Dengen { get => _ATACS_Dengen; set { _ATACS_Dengen = value; propertyChanged(nameof(ATACS_Dengen)); } }
		bool _ATACS_Kaihou;
		public bool ATACS_Kaihou { get => _ATACS_Kaihou; set { _ATACS_Kaihou = value; propertyChanged(nameof(ATACS_Kaihou)); } }
		bool _ATACS_Koutai_Kenchi;
		public bool ATACS_Koutai_Kenchi { get => _ATACS_Koutai_Kenchi; set { _ATACS_Koutai_Kenchi = value; propertyChanged(nameof(ATACS_Koutai_Kenchi)); } }
		bool _ATACS_Kosho;
		public bool ATACS_Kosho { get => _ATACS_Kosho; set { _ATACS_Kosho = value; propertyChanged(nameof(ATACS_Kosho)); } }
		bool _ATACS_1Kei_Kosho;
		public bool ATACS_1Kei_Kosho { get => _ATACS_1Kei_Kosho; set { _ATACS_1Kei_Kosho = value; propertyChanged(nameof(ATACS_1Kei_Kosho)); } }
		bool _ATACS_2Kei_Kosho;
		public bool ATACS_2Kei_Kosho { get => _ATACS_2Kei_Kosho; set { _ATACS_2Kei_Kosho = value; propertyChanged(nameof(ATACS_2Kei_Kosho)); } }
		#endregion


	}
}
