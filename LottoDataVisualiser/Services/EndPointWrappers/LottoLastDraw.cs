using LottoApp.Services.API;

namespace LottoApp.Services.EndPointWrappers
{
	internal class LottoLastDraw
	{
		public async Task<string> Get()
		{
			string endpointURL = "/api/open/v1/lotteries/draw-results/last-results-per-game?gameType=Lotto";

			string JsonResponse = await Call.GetResponse(endpointURL);

			return JsonResponse;
		}
	}
}
