using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace TR.caMonPageMod.HoanDisp
{
	public class BlinkProvider : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(in string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		bool _BlinkState = false;
		public bool BlinkState { get => _BlinkState; set { if (BlinkState != value) { _BlinkState = value; OnPropertyChanged(nameof(BlinkState)); } } }

		int _BlinkRateMS;
		public int BlinkRateMS
		{
			get => _BlinkRateMS;
			set
			{
				if(BlinkRateMS != value)
				{
					_BlinkRateMS = value;
					Timer.Interval = new(0, 0, 0, 0, value);
					OnPropertyChanged(nameof(BlinkRateMS));
				}
			}
		}

		System.Windows.Threading.DispatcherTimer Timer = new();

		public BlinkProvider() => Init(400);
		public BlinkProvider(in int blinkRateMS) => Init(blinkRateMS);
		private void Init(in int blinkRateMS)
		{
			Timer.Interval = new TimeSpan(0, 0, 0, 0, blinkRateMS);
			Timer.Tick += (_, _) => BlinkState = !BlinkState;

			Start();
		}

		public void Start() => Timer.Start();

		public void Stop() => Timer.Stop();
	}

	public class GetBlinkStateInBlinkProviderConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			=> value is BlinkProvider bp ? bp.BlinkState : false;

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			=> throw new NotImplementedException();
	}
}
