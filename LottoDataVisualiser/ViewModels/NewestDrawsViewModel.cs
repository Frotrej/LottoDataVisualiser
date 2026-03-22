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
		
		public List<GameDrawModel> GameDrawsList
		{
			get => _gameDrawsList;
			set
			{
				_gameDrawsList = value;
				OnPropertyChanged(nameof(GameDrawsList));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
