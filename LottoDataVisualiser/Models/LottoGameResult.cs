using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models
{
	internal class LottoGameResult
	{
		public string GameName { get; set; }
		public DateTime DrawDate { get; set; }
		public int[] WinningNumbers { get; set; }
		public int BonusNumber { get; set; }
		public int JackpotAmount { get; set; }
		
		public LottoGameResult(string gameName, DateTime drawDate, int[] winningNumbers, int bonusNumber, int jackpotAmount, int totalWinners)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = winningNumbers;
			BonusNumber = bonusNumber;
			JackpotAmount = jackpotAmount;
		}
	}
}
