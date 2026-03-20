using LottoApp.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LottoApp.ViewModels
{
	internal class RecentDrawsViewModel
	{
/*
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
			LoadNewestDrawsFromApi();
		}
		private async void LoadNewestDrawsFromApi()
		{
			// Call the API to get the latest lotto draw result
			var lotto = await new Services.APIServices.GetLastDrawAsync().Get();

			//possible improvement: instead of calling api for every game separately, create a new api endpoint that returns all the latest draws in one call, then map the response to a list of LastDrawModel and assign it to LottoResult

			LottoResult = lotto;
		}


		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
*/


	}
}


//create a new api endpoint that returns all the latest draws in one call, then map the response to a List<LastDrawModel> and assign it to viewModel