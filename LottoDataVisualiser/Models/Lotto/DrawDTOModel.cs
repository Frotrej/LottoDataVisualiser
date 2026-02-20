using System.Text.Json.Serialization;

namespace LottoApp.Models.Lotto
{
    internal class DrawDTOModel
    {
        [JsonPropertyName("drawSystemId")]
        public int DrawSystemId { get; set; }
        [JsonPropertyName("drawDate")]
		public string DrawDate { get; set; } //replace with DateTime in the future
		[JsonPropertyName("gameType")]
		public string GameType { get; set; } //replace with enum
        [JsonPropertyName("multiplierValue")]
		public int MultiplierValue { get; set; }
        [JsonPropertyName("results")]
		public DrawInfoDTOModel Results { get; set; }
        [JsonPropertyName("showSpecialResults")]
		public bool ShowSpecialResults { get; set; }
        [JsonPropertyName("isNewEuroJackpotDraw")]
		public bool IsNewEuroJackpotDraw { get; set; }
    }

 
}
