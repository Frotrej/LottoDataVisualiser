namespace LottoApp.Models
{
	internal class LottoGameResult
	{
		public string GameName { get; set; }
		public DateTime DrawDate { get; set; }
		public int[] WinningNumbers { get; set; }
		public int BonusNumber { get; set; }
		public int JackpotAmount { get; set; }
		public string RawResponse { get; set; }

		public LottoGameResult(string gameName, DateTime drawDate, int[] winningNumbers, int bonusNumber, int jackpotAmount, string rawResponse)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = winningNumbers;
			BonusNumber = bonusNumber;
			JackpotAmount = jackpotAmount;
			RawResponse = rawResponse;
		}
	}
}
