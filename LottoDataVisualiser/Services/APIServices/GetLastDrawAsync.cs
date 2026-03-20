using LottoApp.Models.DomainModels;
using LottoApp.Models.DTOs;
using System.Text.Json;

namespace LottoApp.Services.APIServices
{
	internal class GetLastDrawAsync
	{
		public async Task<GameDrawModel> Get()
		{
			string json = await new EndPointWrappers.LottoLastDraw().Get();

			List<DrawDTOModel> draw = new();

			GameDrawModel lastDraw = new();

			try
			{
				draw = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

				if (draw == null || draw.Any() == false)
				{
					json = "Bad api response could not map data:" + json;
					GameDrawModel lastDrawBadResponse = new GameDrawModel(json);
					return lastDrawBadResponse;
				}
			}
			catch (Exception ex)
			{
				json = ex.Message + "|json string: " + json;
				GameDrawModel lastDrawDeserializationException = new GameDrawModel(json);
				return lastDrawDeserializationException;
			}

			lastDraw = new GameDrawModel
			{
				GameName = draw[0].Results[0].GameType,
				DrawDate = draw[0].Results[0].DrawDate,
				WinningNumbers = draw[0].Results[0].WinningNumbers,
				BonusNumbers = draw[1].Results[0].WinningNumbers,
				RawResponse = json
			};

			return lastDraw;
		}


	}
}