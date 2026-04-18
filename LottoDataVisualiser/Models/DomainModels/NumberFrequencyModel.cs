using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.DomainModels
{
	public class NumberFrequencyModel
	{
		public int Number { get; set; }
		public int NumberOfOccurrences { get; set; }
		public int PercentOfOccurrencesTotal { get; set; }
	}
}
