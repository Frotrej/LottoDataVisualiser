using System.Net.Http;
using System.Text.Json;

namespace LottoApp.Services.LottoEndPoints
{
	internal class LottoLastDraw
	{
		public async Task<string> Get()
		{
			string JsonResponse = await MakeCall();

			return JsonResponse;
		}

		private async Task<string> MakeCall()
		{
			APIServices.HttpClientFactory httpClientService = new APIServices.HttpClientFactory();
			HttpClient httpClient = httpClientService.GetHttpClient();
			var response = await httpClient.GetAsync("/api/open/v1/lotteries/draw-results/last-results-per-game?gameType=Lotto");

			string jsonResponse;
			try
			{
				response.EnsureSuccessStatusCode();
			}
			catch (HttpRequestException ex)
			{
				string exceptionString = await response.Content.ReadAsStringAsync();
				return exceptionString;
			}
			
			jsonResponse = await response.Content.ReadAsStringAsync();

			return jsonResponse;
		}
	}
}
