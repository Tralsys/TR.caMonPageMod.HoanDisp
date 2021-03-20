using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TR.caMonPageMod.HoanDisp
{
	class MarginConverter : IValueConverter
	{
		public enum Direction { None, LR, UD, Each, L, R, U, D }
		public Direction DirectionSetting { get; set; }

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double val = (double)value;
			return DirectionSetting switch
			{
				Direction.LR => new Thickness(val, 0, val, 0),
				Direction.UD => new Thickness(0, val, 0, val),
				Direction.Each => new Thickness(val),
				Direction.L => new Thickness(val, 0, 0, 0),
				Direction.U => new Thickness(0, val, 0, 0),
				Direction.R => new Thickness(0, 0, val, 0),
				Direction.D => new Thickness(0, 0, 0, val),
				_ => new Thickness(0)
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
