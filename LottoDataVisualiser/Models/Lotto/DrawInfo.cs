using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.Lotto
{
	internal class DrawInfo
	{
		string drawDate { get; set; } //replace with DateTime int the future
		int drawSystemId { get; set; }
		string gameType { get; set; } //replace with enum
		int[] resultsJson { get; set; }
		string specialResults { get; set; }
	}
}
