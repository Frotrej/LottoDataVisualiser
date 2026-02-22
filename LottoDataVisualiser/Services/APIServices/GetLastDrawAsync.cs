using LottoApp.Models.Lotto;
using System.Text.Json;

namespace LottoApp.Services.APIServices
{
	internal class GetLastDrawAsync
	{
		public async Task<LastDrawModel> Get()
		{
			string json = await new LottoEndPoints.LottoLastDraw().Get();

			List<DrawDTOModel> draw = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

			if (draw == null) return null;

			LastDrawModel lastDrawLotto = new LastDrawModel
			{
				GameName = draw[0].Results[0].GameType,
				DrawDate = draw[0].Results[0].DrawDate,
				WinningNumbers = draw[0].Results[0].WinningNumbers,
				BonusNumbers = draw[1].Results[0].WinningNumbers,
				RawResponse = json
			};

			return lastDrawLotto;
		}


	}
}
