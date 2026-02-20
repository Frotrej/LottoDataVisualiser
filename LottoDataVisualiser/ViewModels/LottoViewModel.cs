using LottoApp.Models.Lotto;
using System.ComponentModel;

namespace LottoApp.ViewModels
{
	internal class LottoViewModel : INotifyPropertyChanged
	{

		private LastDrawModel _lottoResult = null!;

		public LastDrawModel LottoResult
		{
			get => _lottoResult;
			set
			{
				_lottoResult = value;
				OnPropertyChanged(nameof(LottoResult));
			}
		}
		public LottoViewModel()
		{
			LoadDataFromApi();
		}
		private async void LoadDataFromApi()
		{
			LottoResult = new Services.APIServices.GetLastDrawAsync().Get();
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
