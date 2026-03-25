using LottoApp.Services.APIServices;
using System.Net.Http;

namespace LottoApp.Services.API
{
	internal static class Call
	{
		public static async Task<string> GetResponse(string endpoint)
		{
			HttpClient httpClient = HttpClientFactory.GetHttpClient();

			var APIresponse = await httpClient.GetAsync(endpoint);

			try
			{
				APIresponse.EnsureSuccessStatusCode();
			}
			catch
			{
				return await APIresponse.Content.ReadAsStringAsync();
			}

			return await APIresponse.Content.ReadAsStringAsync();
		}
	}
}
