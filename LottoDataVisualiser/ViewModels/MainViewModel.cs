using System.ComponentModel;

namespace LottoApp.ViewModels
{
	internal class MainViewModel : INotifyPropertyChanged
	{

		private Models.LottoGameResult _lottoResult = null!;

		public Models.LottoGameResult LottoResult
		{
			get => _lottoResult;
			set
			{
				_lottoResult = value;
				OnPropertyChanged(nameof(LottoResult));
			}
		}
		public MainViewModel()
		{
			LoadDataFromApi();
		}
		private async void LoadDataFromApi()
		{
			string RawAPIResponse = await new Services.LottoEndPoints.GetLastWin().GetRaw();

			LottoResult = new Models.LottoGameResult(" ", DateTime.Now, new int[6], 0, 0, RawAPIResponse);
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
