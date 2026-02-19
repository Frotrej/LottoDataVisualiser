using LottoApp.Models.Lotto;
using System.ComponentModel;

namespace LottoApp.ViewModels
{
	internal class LottoViewModel : INotifyPropertyChanged
	{

		private LastDraw _lottoResult = null!;

		public LastDraw LottoResult
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
			string RawAPIResponse = await new Services.LottoEndPoints.GetLastDraw().GetRaw();



			LottoResult = new LastDraw(RawAPIResponse);
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
