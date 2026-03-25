using System.Text.Json.Serialization;

namespace LottoApp.Models.DTOs
{
	internal class DrawDTOModel
	{
		[JsonPropertyName("drawSystemId")]
		public int DrawSystemId { get; set; }
		[JsonPropertyName("drawDate")]
		public DateTime DrawDate { get; set; }
		[JsonPropertyName("gameType")]
		public string GameType { get; set; } //replace with enum?
		[JsonPropertyName("multiplierValue")]
		public int? MultiplierValue { get; set; }
		
		[JsonPropertyName("results")]
		public List<DrawInfoDTOModel> Results { get; set; }
		[JsonPropertyName("showSpecialResults")]
		public bool ShowSpecialResults { get; set; }
		[JsonPropertyName("isNewEuroJackpotDraw")]
		public bool IsNewEuroJackpotDraw { get; set; }
	}
}
