using LottoApp.Models.DTOs;

namespace LottoApp.Models.DomainModels
{
	internal class GameDrawModel
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
		public int MultiplierValue { get; set; }
		public string GameId { get; set; }
		public bool ShowSpecialResults { get; set; }
		public bool IsEuroJackpot { get; set; }
		public string RawResponse { get; set; }


		public GameDrawModel(string gameName, DateTime drawDate, int[] winningNumbers, int[] bonusNumbers)
		{
			GameName = gameName;
			DrawDate = drawDate;
			WinningNumbers = [winningNumbers[0], winningNumbers[1], winningNumbers[2], winningNumbers[3], winningNumbers[4], winningNumbers[5]];
			BonusNumbers = bonusNumbers;
			MultiplierValue = 0;
			GameId = 0.ToString();
			ShowSpecialResults = false;
			IsEuroJackpot = false;
			RawResponse = string.Empty;
		}
		public GameDrawModel()
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumbers = new int[6];
			MultiplierValue = 0;
			GameId = 0.ToString();
			ShowSpecialResults = false;
			IsEuroJackpot = false;
			RawResponse = "raw response here";
		}
		public GameDrawModel(string rawResponse)
		{
			GameName = "gameName";
			DrawDate = DateTime.Now;
			WinningNumbers = new int[6];
			BonusNumbers = new int[6];
			MultiplierValue = 0;
			GameId = 0.ToString();
			ShowSpecialResults = false;
			IsEuroJackpot = false;
			RawResponse = rawResponse;
		}
		public GameDrawModel(string rawResponse, List<DrawDTOModel> dtoList)
		{
			GameName = dtoList[0].GameType;
			DrawDate = dtoList[0].DrawDate;
			WinningNumbers = dtoList[0].Results[0].Results;
			BonusNumbers = dtoList[0].Results[0].SpecialResults;
			MultiplierValue = dtoList[0].MultiplierValue ?? 0;
			GameId = dtoList[0].DrawSystemId.ToString();
			ShowSpecialResults = false;
			IsEuroJackpot = false;
			RawResponse = rawResponse;
		}
		public GameDrawModel(string rawResponse, DrawDTOModel dto)
		{
			GameName = dto.GameType;
			DrawDate = dto.DrawDate;
			WinningNumbers = dto.Results[0].Results;
			BonusNumbers = dto.Results[0].SpecialResults;
			MultiplierValue = dto.MultiplierValue ?? 0;
			GameId = dto.DrawSystemId.ToString();
			ShowSpecialResults = dto.ShowSpecialResults;
			IsEuroJackpot = dto.IsNewEuroJackpotDraw;
			RawResponse = rawResponse;
		}
	}
}
