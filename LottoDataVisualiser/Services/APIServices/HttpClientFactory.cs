using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;

namespace LottoApp.Services.APIServices
{
	public class HttpClientFactory
	{
		private readonly HttpClient httpClient;
		public HttpClientFactory()
		{
			httpClient = new HttpClient();

			GetDataFromAppSettings();
		}

		private void GetDataFromLocalVariables()
		{
			//apiKey from powershell environmental console (setx MY_API_KEY "your key")
			string apiKey = new string(Environment.GetEnvironmentVariable("MY_API_KEY"));
			httpClient.DefaultRequestHeaders.Add("secret", apiKey);

			//base url as uri for http client to call api
			var baseUrlAsUri = new Uri("https://developers.lotto.pl");
			httpClient.BaseAddress = baseUrlAsUri;
		}

		private void GetDataFromAppSettings()
		{
			IConfigurationBuilder builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
#if DEBUG
			builder.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);
#endif

			httpClient.DefaultRequestHeaders.Add(builder.Build().GetSection("header").Value, builder.Build().GetSection("APIKey").Value);

			httpClient.BaseAddress = new Uri(builder.Build().GetSection("APIBaseUrl").Value);


			//https://www.youtube.com/watch?v=ASraHYMi808&t=1540s
			//worki in progress
		}

		public HttpClient GetHttpClient()
		{
			return httpClient;
		}


	}
}
