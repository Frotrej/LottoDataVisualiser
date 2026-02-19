namespace LottoApp.Models.Lotto
{
	internal class LastDraw
	{
		public string GameName { get; set; }
		public DateTime DrawDate { get; set; }
		public int[] WinningNumbers { get; set; }
		public int BonusNumber { get; set; }
		public int JackpotAmount { get; set; }
		public string RawResponse { get; set; }


		public LastDraw(string gameName, DateTime drawDate, int[] winningNumbers, int bonusNumber, int jackpotAmount, string rawResponse)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = winningNumbers;
			BonusNumber = bonusNumber;
			JackpotAmount = jackpotAmount;
			RawResponse = rawResponse;
		}
		public LastDraw()
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumber = 0;
			JackpotAmount = 0;
			RawResponse = "raw response here";
		}
		public LastDraw(string rawResponse)
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumber = 0;
			JackpotAmount = 0;
			RawResponse = rawResponse;
		}
	}
}
