using LottoApp.Services.EndPointWrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.DomainModels
{
	internal class NumbersFrequencyModel
	{
		public int TotalDraws { get; set; }
		public List<NumberFrequencyModel> NumbersFrequency { get; set; }
		public string ErrorLog { get; set; }

		public NumbersFrequencyModel()
		{
			TotalDraws = 0;
			NumbersFrequency = new();
			ErrorLog = string.Empty;
		}
		public NumbersFrequencyModel(string rawResponse)
		{
			TotalDraws = 0;
			NumbersFrequency = new();
			ErrorLog = rawResponse;
		}
		public NumbersFrequencyModel(int totalDraws, List<NumberFrequencyModel> frequencyList, string rawResponse)
		{
			TotalDraws = totalDraws;
			NumbersFrequency = frequencyList;
			ErrorLog = rawResponse;
		}

	}


}
