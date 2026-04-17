using LottoApp.Services.API;

namespace LottoApp.Services.EndPointWrappers
{
	internal class NumbersFrequency
	{
		public string GameType { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }

		public NumbersFrequency()
		{
			GameType = "Lotto";
			DateFrom = new(2025,1,1,0,0,0);
			DateTo = new(2026, 1, 1, 0, 0, 0);
		}
		public NumbersFrequency(string gameType, DateTime dateFrom, DateTime dateTo)
		{
			GameType = gameType;
			DateFrom = dateFrom;
			DateTo = dateTo;
		}

		public async Task<string> Get()
		{
			string endpointURL = $"/api/open/v1/lotteries/draw-statistics/numbers-frequency?gameType={GameType}&dateFrom={DateFrom}&dateTo={DateTo}";
			
			string JsonResponse = await Call.GetResponse(endpointURL);

			return JsonResponse;
		}
	}
}
