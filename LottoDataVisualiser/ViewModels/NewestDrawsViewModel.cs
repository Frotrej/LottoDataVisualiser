using LottoApp.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LottoApp.ViewModels
{
	internal class NewestDrawsViewModel
	{
		private List<GameDrawModel> _gameDrawsList = null!;
		
		public List<GameDrawModel> GamesDrawsList
		{
			get => _gameDrawsList;
			set
			{
				_gameDrawsList = value;
				OnPropertyChanged(nameof(GamesDrawsList));
			}
		}

		public async Task Initialize()
		{
			GamesDrawsList = await Services.APIServices.GetAllGamesDrawsAsync.Get();
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
