using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace TR.caMonPageMod.HoanDisp
{
	class TextWritingDirectionConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string str = value as string;
			if(str is not null && str.Length > 0)
			{
				StringBuilder sb = new StringBuilder();
				foreach (var s in str)
					sb.Append(s).Append(Environment.NewLine);
				return sb.Remove(sb.Length - Environment.NewLine.Length, 1).ToString();
			}
			return string.Empty;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
