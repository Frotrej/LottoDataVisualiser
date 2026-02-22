using System.Net.Http;

namespace LottoApp.Services.APIServices
{
	public class HttpClientFactory
	{
		private readonly System.Net.Http.HttpClient httpClient;
		public HttpClientFactory()
		{
			httpClient = new System.Net.Http.HttpClient();

			//apiKey from powershell environmental console (setx MY_API_KEY "your key")
			string apiKey = new string(Environment.GetEnvironmentVariable("MY_API_KEY"));
			httpClient.DefaultRequestHeaders.Add("secret", apiKey);

			//base url as uri for http client to call api
			var baseUrlAsUri = new Uri("https://developers.lotto.pl");
			httpClient.BaseAddress = baseUrlAsUri;
		}

		public System.Net.Http.HttpClient GetHttpClient()
		{
			return httpClient;
		}


	}
}
