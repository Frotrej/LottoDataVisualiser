using LottoApp.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LottoApp.ViewModels
{
    class GameTabs : INotifyPropertyChanged
	{
        private ObservableCollection<GameDrawModel> _gamesResults = new();

		public ObservableCollection<GameDrawModel> GamesResults
		{
			get => _gamesResults;
			set
			{
				if (_gamesResults != value)
				{
					_gamesResults = value;
					OnPropertyChanged(nameof(GamesResults));
				}
			}
		}

        public async Task Initialize()
		{
			var gamesResultsAsList = await Services.APIServices.GetAllGamesDrawsAsync.Get();

			GamesResults.Clear();
			if (gamesResultsAsList == null)
			{
				return;
			}

			foreach (var item in gamesResultsAsList)
			{
				GamesResults.Add(item);
			}
				
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
