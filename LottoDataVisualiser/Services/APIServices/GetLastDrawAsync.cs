using LottoApp.Models.DomainModels;
using LottoApp.Models.DTOs;
using System.Text.Json;

namespace LottoApp.Services.APIServices
{
	internal static class GetLastDrawAsync
	{
		public static async Task<GameDrawModel> Get()
		{
			string json = await GetApiResponse();

			//gamesDTO is a list because api returns 2 objects in an array, second one being the LottoPlus which requires using DrawDTOModel as a List
			List<DrawDTOModel> gamesDTO = new();

			GameDrawModel lastLottoDraw = new();

			if (!DeserializeAndCatch(json, ref gamesDTO, ref lastLottoDraw))
			{
				return lastLottoDraw;
			}

			lastLottoDraw = new GameDrawModel(json, gamesDTO[0]);

			return lastLottoDraw;
		}
		private static async Task<string> GetApiResponse()
		{
			return await new EndPointWrappers.LottoLastDraw().Get();
		}
		private static bool DeserializeAndCatch(string json, ref List<DrawDTOModel> dto, ref GameDrawModel lastLottoDraw)
		{
			try
			{
				dto = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

				if (dto == null || dto.Count == 0)
				{
					json = "Bad api response could not map data:" + json;
					GameDrawModel lastDrawBadResponse = new GameDrawModel(json);
					return false;
				}
			}
			catch (Exception ex)
			{
				json = ex.Message + "|json string: " + json;

				lastLottoDraw = new GameDrawModel(json);
				return false;
			}

			return true;
		}
	}
}