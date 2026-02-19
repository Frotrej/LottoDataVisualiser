using System.Net.Http;

namespace LottoApp.Services.LottoEndPoints
{
	internal class GetLastDraw
	{
		public async Task<string> GetRaw()
		{
			HttpResponseMessage rawResponse = await MakeCall();

			string rawJson = await rawResponse.Content.ReadAsStringAsync();

			return rawJson;
		}
		/*public async Task<Models.LastDraw> GetDeserialized()
		{
			HttpResponseMessage rawResponse = await MakeCall();
			string rawJson = await rawResponse.Content.ReadAsStringAsync();
			Models.LastDraw deserializedResponse = System.Text.Json.JsonSerializer.Deserialize<Models.LastDraw>(rawJson);
			return deserializedResponse;
		}*/

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
