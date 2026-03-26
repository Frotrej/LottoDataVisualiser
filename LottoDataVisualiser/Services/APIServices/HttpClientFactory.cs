using LottoApp.Common;
using System.Net.Http;

namespace LottoApp.Services.APIServices
{
	public static class HttpClientFactory
	{
		private static readonly HttpClient httpClient;
		static HttpClientFactory()
		{
			httpClient = new HttpClient();

			try
			{
				LoadDataFromLocalVariables();
			}
			catch
			{
				try
				{
					LoadConfig();
				}
				catch
				{
					//swallow exception, if both methods fail, the http client will be created without configuration, and the api calls will fail, improvement:log the exception, or show a message to the user
				}
			}
		}

		public static HttpClient GetHttpClient()
		{
			return httpClient;
		}
		private static void LoadConfig()
		{
			var config = BuildConfig.GetAppsettingsConfig();

			httpClient.DefaultRequestHeaders.Add(config["header"], config["APIKey"]);

			httpClient.BaseAddress = new Uri(config["APIBaseUrl"]);
		}
		private static void LoadDataFromLocalVariables()
		{
			//apiKey from powershell, environmental variable, (setx MY_API_KEY "your key")
			string apiKey = (Environment.GetEnvironmentVariable("MY_API_KEY"));
			httpClient.DefaultRequestHeaders.Add("secret", apiKey);

			//base url as uri for http client to call api
			httpClient.BaseAddress = new Uri("https://developers.lotto.pl");
		}
	}
}
