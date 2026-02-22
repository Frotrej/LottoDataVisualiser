namespace LottoApp.Models.Lotto
{
	internal class LastDrawModel
	{
		public string GameName { get; set; }
		public DateTime DrawDate { get; set; }
		public int[] WinningNumbers { get; set; }
		public string WinningNumbersText
		{
			get => WinningNumbers != null
				? string.Join(", ", WinningNumbers)
				: string.Empty;
		}
		public int[] BonusNumbers { get; set; }
		public string BonusNumbersText
		{
			get => BonusNumbers != null
				? string.Join(", ", BonusNumbers)
				: string.Empty;
		}
		public string RawResponse { get; set; }


		public LastDrawModel(string gameName, DateTime drawDate, int[] winningNumbers, int[] bonusNumbers)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = [winningNumbers[0], winningNumbers[1], winningNumbers[2], winningNumbers[3], winningNumbers[4], winningNumbers[5]];
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
