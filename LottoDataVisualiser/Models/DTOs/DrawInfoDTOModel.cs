using System.Text.Json.Serialization;

namespace LottoApp.Models.DTOs
{
	internal class DrawInfoDTOModel
	{
		[JsonPropertyName("drawDate")]
		public DateTime DrawDate { get; set; }
		[JsonPropertyName("drawSystemId")]
		public int DrawSystemId { get; set; }
		[JsonPropertyName("gameType")]
		public string GameType { get; set; } //replace with enum?
		[JsonPropertyName("resultsJson")]
		public int[] Results { get; set; }
		[JsonPropertyName("specialResults")]
		public int[] SpecialResults { get; set; }
	}
}
