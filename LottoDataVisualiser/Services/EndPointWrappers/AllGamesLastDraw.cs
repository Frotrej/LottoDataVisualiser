using LottoApp.Services.API;

namespace LottoApp.Services.EndPointWrappers
{
	internal class AllGamesLastDraw
	{
		public async Task<string> Get()
		{
			string endpointURL = "/api/open/v1/lotteries/draw-results/last-results";

			string JsonResponse = await Call.GetResponse(endpointURL);

			return JsonResponse;
		}
	}
}
