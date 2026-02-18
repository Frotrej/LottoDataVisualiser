using System.Net.Http;

namespace LottoApp.Services.LottoEndPoints
{
	internal class GetLastWin
	{
		public async Task<string> GetRaw()
		{
			APIServices.HttpClientService httpClientService = new APIServices.HttpClientService();
			HttpClient _httpClient = httpClientService.GetHttpClient();

			var response = await _httpClient.GetAsync("/api/open/v1/lotteries/draw-results/last-results-per-game?gameType=Lotto");
			response.EnsureSuccessStatusCode();

			string rawJson = await response.Content.ReadAsStringAsync();

			return rawJson;
		}
	}
}
