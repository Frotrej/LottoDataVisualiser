namespace LottoApp.Models.Lotto
{
	internal class LastDrawModel
	{
		public string GameName { get; set; }
		public DateTime DrawDate { get; set; }
		public int[] WinningNumbers { get; set; }
		public int[] BonusNumbers { get; set; }
		public string RawResponse { get; set; }


		public LastDrawModel(string gameName, DateTime drawDate, int[] winningNumbers, int[] bonusNumbers)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = winningNumbers;
			BonusNumbers = bonusNumbers;
			RawResponse = string.Empty;
		}
		public LastDrawModel()
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumbers = new int[6];
			RawResponse = "raw response here";
		}
		public LastDrawModel(string rawResponse)
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumbers = new int[6];
			RawResponse = rawResponse;
		}
	}
}
