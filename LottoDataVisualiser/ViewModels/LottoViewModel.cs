using LottoApp.Models.DomainModels;
using System.ComponentModel;

namespace LottoApp.ViewModels
{
	internal class LottoViewModel : INotifyPropertyChanged
	{

		private GameDrawModel _lottoResult = null!;

		public GameDrawModel LottoResult
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
			LoadNewestDrawsFromApi();
		}
		private async void LoadNewestDrawsFromApi()
		{
			var lotto = await Services.APIServices.GetLastDrawAsync.Get();

			LottoResult = lotto;
		}


		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
