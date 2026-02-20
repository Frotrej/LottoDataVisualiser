using System.Net.Http;
using System.Text.Json;

namespace LottoApp.Services.LottoEndPoints
{
	internal class LottoLastDraw
	{
		public async Task<string> Get()
		{
			HttpResponseMessage rawResponse = await MakeCall();

			string rawJson = await rawResponse.Content.ReadAsStringAsync();

			return rawJson;
		}

		private async Task<HttpResponseMessage> MakeCall()
		{
			APIServices.HttpClientFactory httpClientService = new APIServices.HttpClientFactory();
			HttpClient _httpClient = httpClientService.GetHttpClient();

			var response = await _httpClient.GetAsync("/api/open/v1/lotteries/draw-results/last-results-per-game?gameType=Lotto");
			response.EnsureSuccessStatusCode();

			return response;
		}
	}
}
