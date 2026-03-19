using LottoApp.Models.DomainModels;
using System.ComponentModel;

namespace LottoApp.ViewModels
{
	internal class LottoViewModel : INotifyPropertyChanged
	{

		private List<LastDrawModel> _lottoResult = null!;

		public List<LastDrawModel> LottoResult
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
			// Call the API to get the latest lotto draw result
			var lotto = await new Services.APIServices.GetLastDrawAsync().Get();

			//possible improvement: instead of calling api for every game separately, create a new api endpoint that returns all the latest draws in one call, then map the response to a list of LastDrawModel and assign it to LottoResult

			LottoResult.Add(lotto);
		}


		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
