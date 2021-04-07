using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

using BIDSDataUpdateNotifier;

namespace TR.caMonPageMod.HoanDisp
{
	/// <summary>Interaction logic for SettingPage.xaml</summary>
	public partial class SettingPage : UserControl
	{
		PageSelectControl PSelCtrl { get; }
		public SettingPage(HoanLampState hls, PageSelectControl pselctrl)
		{
			this.DataContext = hls;
			PSelCtrl = pselctrl;//TopPageインスタンスを引っ張ってくるため

			InitializeComponent();

			SettingListView.DataContextChanged += SettingListView_DataContextChanged;//列挙を更新するため
		}

		private void SettingListView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			var listitems = new List<SettingListViewDataClass>();

			object obj = e.NewValue;
			if (obj is not null)
				foreach (var propinfo in obj.GetType().GetProperties())//objが持つプロパティを列挙
					if (propinfo.GetValue(obj) is IValueChecker<bool> targetObj)//プロパティの型がIValueCheckerにキャスト可能かどうか
						listitems.Add(new() { PropName = propinfo.Name, TargetObject = targetObj });

			SettingListView.ItemsSource = listitems;//要素が0であってもであっても更新する
		}

		private void SaveButtonClicked(object sender, RoutedEventArgs e) { }//=> (SettingListView.DataContext as ILampsClassBASE)?.SaveIndexesToXML();//BIDSDataUpdateNotifier v1.1にてインターフェイス経由での設定保存メソッドへのアクセスが可能になるまで保留

		Button LastSelectedButton = null;
		private void HoanSelectBtnClicked(object sender, RoutedEventArgs e)
		{
			if (LastSelectedButton is not null)
				LastSelectedButton.IsEnabled = true;
			
			LastSelectedButton = sender as Button;

			if(LastSelectedButton is not null)
			{
				SettingListView.DataContext = LastSelectedButton.DataContext;
				LastSelectedButton.IsEnabled = false;
			}
		}

		private void LoadButtonClicked(object sender, RoutedEventArgs e) { }//=> (SettingListView.DataContext as ILampsClassBASE)?.LoadIndexesFromXML();//BIDSDataUpdateNotifier v1.1にてインターフェイス経由での設定保存メソッドへのアクセスが可能になるまで保留

		private void BackToSelectPageClicked(object sender, RoutedEventArgs e) => PSelCtrl.TP.ChangeThePage(PSelCtrl);
	}

	public class SettingListViewDataClass : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(in string s) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));

		private string _PropName = string.Empty;
		/// <summary>TargetObjectのインスタンスが意味する機能の名前</summary>
		public string PropName { get => _PropName; set { _PropName = value; OnPropertyChanged(nameof(PropName)); } }

		private IValueChecker<bool> _TargetObject = null;
		/// <summary>設定を変更するインスタンス</summary>
		public IValueChecker<bool> TargetObject { get => _TargetObject; set { _TargetObject = value; OnPropertyChanged(nameof(TargetObject)); } }
	}
}
