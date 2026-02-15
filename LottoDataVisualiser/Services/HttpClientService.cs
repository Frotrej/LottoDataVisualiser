using System.Net.Http;

namespace LottoApp.Services
{
	public class HttpClientService
	{
		private readonly HttpClient httpClient;
		public HttpClientService()
		{
			httpClient = new HttpClient();

			//apiKey from powershell environmental console (setx MY_API_KEY "your key")
			string apiKey = new string(Environment.GetEnvironmentVariable("MY_API_KEY"));
			httpClient.DefaultRequestHeaders.Add("secret", apiKey);

			//base url as uri for http client to call api
			var baseUrlAsUri = new Uri("https://developers.lotto.pl");
			httpClient.BaseAddress = baseUrlAsUri;
		}

		public int GetResults(int a, int b)
		{
			return a * b;
		}

	}
}
