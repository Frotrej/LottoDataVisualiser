using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.DTOs
{
	internal class NumberFrequencyDTOModel
	{
        public int Number { get; set; }
		public int NumberOfOccurrences { get; set; }
		public int PercentOfOccurrencesTotal { get; set; }
	}
}