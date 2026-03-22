using LottoApp.Models.DomainModels;
using LottoApp.Models.DTOs;

namespace LottoApp.Services.APIServices
{
	internal class GetAllGamesDrawsAsync
	{
		public static async Task<List<GameDrawModel>> Get()
		{
			string json = await GetApiResponse();

			List<DrawDTOModel> gamesDTO = new();

			List<GameDrawModel> latestGamesDraws = new();

			if (!DeserializeHelper.JsonToDto(json, ref gamesDTO, ref latestGamesDraws))
			{
				return latestGamesDraws;
			}

			foreach (var draw in gamesDTO)
			{
				latestGamesDraws.Add(new GameDrawModel(json, draw));
			}

			return latestGamesDraws;
		}

		private static async Task<string> GetApiResponse()
		{
			return await new EndPointWrappers.AllGamesLastDraw().Get();
		}
	}
}
