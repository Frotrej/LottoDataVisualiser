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

			///gamesDTO is a list because API can return more objects in an array, eg. first one beint Lotto and second one being LottoPlus which requires using DrawDTOModel as a List
			List<DrawDTOModel> gamesDTO = new();

			GameDrawModel lastLottoDraw = new();

			if (!DeserializeHelper.JsonToDto(json, ref gamesDTO, ref lastLottoDraw))
			{
				return lastLottoDraw;
			}

			lastLottoDraw = new GameDrawModel(json, gamesDTO);

			return lastLottoDraw;
		}
		private static async Task<string> GetApiResponse()
		{
			return await new EndPointWrappers.LottoLastDraw().Get();
		}
		
	}
}