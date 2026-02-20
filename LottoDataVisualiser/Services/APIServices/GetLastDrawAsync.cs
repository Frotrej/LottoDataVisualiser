using LottoApp.Models.Lotto;
using System.Text.Json;

namespace LottoApp.Services.APIServices
{
	internal class GetLastDrawAsync
	{
		public LastDrawModel Get()
		{
			string json = new LottoEndPoints.LottoLastDraw().Get().Result;

			List<DrawDTOModel> draw = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

			if (draw == null) return null;

			LastDrawModel lastDrawLotto = new LastDrawModel
			{
				GameName = draw[0].Results.GameType,
				DrawDate = DateTime.Parse(draw[0].Results.DrawDate),
				WinningNumbers = draw[0].Results.WinningNumbers,
				BonusNumbers = draw[1].Results.WinningNumbers,
				RawResponse = json
			};

			return lastDrawLotto;
		}


	}
}
