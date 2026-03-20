using LottoApp.Services.APIServices;
using System.Net.Http;

namespace LottoApp.Services.API
{
	internal static class Call
	{
		public static async Task<string> GetResponse(string endpoint)
		{
			HttpClientFactory httpClientService = new HttpClientFactory();
			HttpClient httpClient = httpClientService.GetHttpClient();
			var response = await httpClient.GetAsync(endpoint);
			string jsonResponse;
			try
			{
				response.EnsureSuccessStatusCode();
			}
			catch
			{
				string exceptionString = await response.Content.ReadAsStringAsync();
				return exceptionString;
			}
			jsonResponse = await response.Content.ReadAsStringAsync();
			return jsonResponse;
		}
	}
}
