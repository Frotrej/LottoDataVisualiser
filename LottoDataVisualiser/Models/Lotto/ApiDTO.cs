using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.Lotto
{
    internal class ApiDTO
    {
        public int DrawSystemId { get; set; }
		public string drawDate { get; set; } //replace with DateTime in the future
		public string gameType { get; set; } //replace with enum
		public int multiplierValue { get; set; }
		public DrawInfo results { get; set; }
        public bool showSpecialResults { get; set; }
        public bool isNewEuroJackpotDraw { get; set; }
    }
}
