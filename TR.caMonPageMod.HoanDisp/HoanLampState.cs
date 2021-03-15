using System;
using System.ComponentModel;

namespace TR.caMonPageMod.HoanDisp
{
	public class HoanLampState : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		void propertyChanged(in string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		#region ATS-P
		HoanLampClass _ATS_P = new(6);
		public HoanLampClass ATS_P { get => _ATS_P; set { _ATS_P = value; propertyChanged(nameof(ATS_P)); } }

		HoanLampClass _P_Dengen = new(0);
		public HoanLampClass P_Dengen { get => _P_Dengen; set { _P_Dengen = value; propertyChanged(nameof(P_Dengen)); } }

		HoanLampClass _P_Pattern_Sekkin = new(3);
		public HoanLampClass P_Pattern_Sekkin { get => _P_Pattern_Sekkin; set { _P_Pattern_Sekkin = value; propertyChanged(nameof(P_Pattern_Sekkin)); } }

		HoanLampClass _P_Joyo_Brake = new(5);
		public HoanLampClass P_Joyo_Brake { get => _P_Joyo_Brake; set { _P_Joyo_Brake = value; propertyChanged(nameof(P_Joyo_Brake)); } }

		HoanLampClass _P_Hijo_Brake = new(8);
		public HoanLampClass P_Hijo_Brake { get => _P_Hijo_Brake; set { _P_Hijo_Brake = value; propertyChanged(nameof(P_Hijo_Brake)); } }

		HoanLampClass _P_Brake_Kaihou = new(4);
		public HoanLampClass P_Brake_Kaihou { get => _P_Brake_Kaihou; set { _P_Brake_Kaihou = value; propertyChanged(nameof(P_Brake_Kaihou)); } }

		HoanLampClass _P_Kosyo = new(7);
		public HoanLampClass P_Kosyo { get => _P_Kosyo; set { _P_Kosyo = value; propertyChanged(nameof(P_Kosyo)); } }
		#endregion

		#region ATS-S
		HoanLampClass _ATS_Dengen = new(0);
		public HoanLampClass ATS_Dengen { get => _ATS_Dengen; set { _ATS_Dengen = value; propertyChanged(nameof(ATS_Dengen)); } }

		HoanLampClass _ATS_Dousa = new(1);
		public HoanLampClass ATS_Dousa { get => _ATS_Dousa; set { _ATS_Dousa = value; propertyChanged(nameof(ATS_Dousa)); } }
		#endregion

		#region TASC
		HoanLampClass _TASC_Dengen = new();
		/// <summary>TASC OR TASC電源</summary>
		public HoanLampClass TASC_Dengen { get => _TASC_Dengen; set { _TASC_Dengen = value; propertyChanged(nameof(TASC_Dengen)); } }
		HoanLampClass _TASC_Pattern = new();
		/// <summary>TASCパターン OR TASC制御</summary>
		public HoanLampClass TASC_Pattern { get => _TASC_Pattern; set { _TASC_Pattern = value; propertyChanged(nameof(TASC_Pattern)); } }
		HoanLampClass _TASC_Brake = new();
		public HoanLampClass TASC_Brake { get => _TASC_Brake; set { _TASC_Brake = value; propertyChanged(nameof(TASC_Brake)); } }
		HoanLampClass _TASC_Off = new();
		public HoanLampClass TASC_Off { get => _TASC_Off; set { _TASC_Off = value; propertyChanged(nameof(TASC_Off)); } }
		HoanLampClass _TASC_Kosyo = new();
		public HoanLampClass TASC_Kosyo { get => _TASC_Kosyo; set { _TASC_Kosyo = value; propertyChanged(nameof(TASC_Kosyo)); } }
		HoanLampClass _Inching_SeigyoChu = new();
		public HoanLampClass Inching_SeigyoChu { get => _Inching_SeigyoChu; set { _Inching_SeigyoChu = value; propertyChanged(nameof(Inching_SeigyoChu)); } }
		#endregion

		#region FD
		HoanLampClass _Tei_Ichi = new();
		public HoanLampClass Tei_Ichi { get => _Tei_Ichi; set { _Tei_Ichi = value; propertyChanged(nameof(Tei_Ichi)); } }
		HoanLampClass _CarDoor_AllClosed = new();
		public HoanLampClass CarDoor_AllClosed { get => _CarDoor_AllClosed; set { _CarDoor_AllClosed = value; propertyChanged(nameof(CarDoor_AllClosed)); } }
		HoanLampClass _FD_AllClosed = new();
		public HoanLampClass FD_AllClosed { get => _FD_AllClosed; set { _FD_AllClosed = value; propertyChanged(nameof(FD_AllClosed)); } }
		HoanLampClass _FD_Renkei = new();
		public HoanLampClass FD_Renkei { get => _FD_Renkei; set { _FD_Renkei = value; propertyChanged(nameof(FD_Renkei)); } }
		HoanLampClass _FD_Bunri = new();
		public HoanLampClass FD_Bunri { get => _FD_Bunri; set { _FD_Bunri = value; propertyChanged(nameof(FD_Bunri)); } }
		HoanLampClass _FD_TendoBoshi_Brake = new();
		public HoanLampClass FD_TendoBoshi_Brake { get => _FD_TendoBoshi_Brake; set { _FD_TendoBoshi_Brake = value; propertyChanged(nameof(FD_TendoBoshi_Brake)); } }
		#endregion

		#region D-ATC
		HoanLampClass _Digital_ATC = new();
		public HoanLampClass Digital_ATC { get => _Digital_ATC; set { _Digital_ATC = value; propertyChanged(nameof(Digital_ATC)); } }
		HoanLampClass _ATC = new();
		public HoanLampClass ATC { get => _ATC; set { _ATC = value; propertyChanged(nameof(ATC)); } }
		HoanLampClass _DATC_Off = new();
		public HoanLampClass DATC_Off { get => _DATC_Off; set { _DATC_Off = value; propertyChanged(nameof(DATC_Off)); } }
		HoanLampClass _DATC_Pattern_Teigen = new();
		public HoanLampClass DATC_Pattern_Teigen { get => _DATC_Pattern_Teigen; set { _DATC_Pattern_Teigen = value; propertyChanged(nameof(DATC_Pattern_Teigen)); } }
		HoanLampClass _DATC_Hijo_Unten = new();
		public HoanLampClass DATC_Hijo_Unten { get => _DATC_Hijo_Unten; set { _DATC_Hijo_Unten = value; propertyChanged(nameof(DATC_Hijo_Unten)); } }
		HoanLampClass _DATC_Joyo = new();
		public HoanLampClass DATC_Joyo { get => _DATC_Joyo; set { _DATC_Joyo = value; propertyChanged(nameof(DATC_Joyo)); } }
		HoanLampClass _DATC_Hijo = new();
		public HoanLampClass DATC_Hijo { get => _DATC_Hijo; set { _DATC_Hijo = value; propertyChanged(nameof(DATC_Hijo)); } }
		HoanLampClass _DATC_TeitsuBoshi_Dousa = new();
		public HoanLampClass DATC_TeitsuBoshi_Dousa { get => _DATC_TeitsuBoshi_Dousa; set { _DATC_TeitsuBoshi_Dousa = value; propertyChanged(nameof(DATC_TeitsuBoshi_Dousa)); } }
		HoanLampClass _DATC_Power = new();
		public HoanLampClass DATC_Power { get => _DATC_Power; set { _DATC_Power = value; propertyChanged(nameof(DATC_Power)); } }
		HoanLampClass _DATC_Kaihou = new();
		public HoanLampClass DATC_Kaihou { get => _DATC_Kaihou; set { _DATC_Kaihou = value; propertyChanged(nameof(DATC_Kaihou)); } }
		#endregion

		#region ATACS
		HoanLampClass _ATACS_ShajoID_Kosho = new();
		public HoanLampClass ATACS_ShajoID_Kosho { get => _ATACS_ShajoID_Kosho; set { _ATACS_ShajoID_Kosho = value; propertyChanged(nameof(ATACS_ShajoID_Kosho)); } }
		HoanLampClass _ATACS = new();
		public HoanLampClass ATACS { get => _ATACS; set { _ATACS = value; propertyChanged(nameof(ATACS)); } }
		HoanLampClass _ATACS_Off = new();
		public HoanLampClass ATACS_Off { get => _ATACS_Off; set { _ATACS_Off = value; propertyChanged(nameof(ATACS_Off)); } }
		HoanLampClass _ATACS_Pattern_Teigen = new();
		public HoanLampClass ATACS_Pattern_Teigen { get => _ATACS_Pattern_Teigen; set { _ATACS_Pattern_Teigen = value; propertyChanged(nameof(ATACS_Pattern_Teigen)); } }
		HoanLampClass _ATACS_Hijo_Unten = new();
		public HoanLampClass ATACS_Hijo_Unten { get => _ATACS_Hijo_Unten; set { _ATACS_Hijo_Unten = value; propertyChanged(nameof(ATACS_Hijo_Unten)); } }
		HoanLampClass _ATACS_Joyo = new();
		public HoanLampClass ATACS_Joyo { get => _ATACS_Joyo; set { _ATACS_Joyo = value; propertyChanged(nameof(ATACS_Joyo)); } }
		HoanLampClass _ATACS_Hijo = new();
		public HoanLampClass ATACS_Hijo { get => _ATACS_Hijo; set { _ATACS_Hijo = value; propertyChanged(nameof(ATACS_Hijo)); } }
		HoanLampClass _ATACS_TeitsuBoshi_Dousa = new();
		public HoanLampClass ATACS_TeitsuBoshi_Dousa { get => _ATACS_TeitsuBoshi_Dousa; set { _ATACS_TeitsuBoshi_Dousa = value; propertyChanged(nameof(ATACS_TeitsuBoshi_Dousa)); } }
		HoanLampClass _ATACS_Dengen = new();
		public HoanLampClass ATACS_Dengen { get => _ATACS_Dengen; set { _ATACS_Dengen = value; propertyChanged(nameof(ATACS_Dengen)); } }
		HoanLampClass _ATACS_Kaihou = new();
		public HoanLampClass ATACS_Kaihou { get => _ATACS_Kaihou; set { _ATACS_Kaihou = value; propertyChanged(nameof(ATACS_Kaihou)); } }
		HoanLampClass _ATACS_Koutai_Kenchi = new();
		public HoanLampClass ATACS_Koutai_Kenchi { get => _ATACS_Koutai_Kenchi; set { _ATACS_Koutai_Kenchi = value; propertyChanged(nameof(ATACS_Koutai_Kenchi)); } }
		HoanLampClass _ATACS_Kosho = new();
		public HoanLampClass ATACS_Kosho { get => _ATACS_Kosho; set { _ATACS_Kosho = value; propertyChanged(nameof(ATACS_Kosho)); } }
		HoanLampClass _ATACS_1Kei_Kosho = new();
		public HoanLampClass ATACS_1Kei_Kosho { get => _ATACS_1Kei_Kosho; set { _ATACS_1Kei_Kosho = value; propertyChanged(nameof(ATACS_1Kei_Kosho)); } }
		HoanLampClass _ATACS_2Kei_Kosho = new();
		public HoanLampClass ATACS_2Kei_Kosho { get => _ATACS_2Kei_Kosho; set { _ATACS_2Kei_Kosho = value; propertyChanged(nameof(ATACS_2Kei_Kosho)); } }
		#endregion


	}

	public class HoanLampClass : INotifyPropertyChanged, IDisposable
	{
		public HoanLampClass(int index = -1)
		{
			Index = index;
			BIDSSMemLib.SMemLib.PanelDChanged += SMemLib_PanelDChanged;
		}
		

		private void SMemLib_PanelDChanged(object sender, BIDSSMemLib.SMemLib.ArrayDChangedEArgs e)
		{
			if (Index < 0 || e.NewArray.Length <= Index) //Index value is invalid OR Index is running out from readable range
				return;

			IsLighting = e.NewArray[Index] > 0;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		void propertyChanged(in string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		private int _Index = -1;
		public int Index { get => _Index; set { if (_Index != value) { _Index = value; propertyChanged(nameof(Index)); } } }

		private bool _IsLighting = false;

		public bool IsLighting { get => _IsLighting; set { if (_IsLighting != value) { _IsLighting = value; propertyChanged(nameof(IsLighting)); } } }


		#region IDisposed
		private bool disposedValue;
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					BIDSSMemLib.SMemLib.PanelDChanged -= SMemLib_PanelDChanged;
				}

				disposedValue = true;
			}
		}


		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
