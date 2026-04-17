using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Models.DTOs
{
	internal class NumbersFrequencyDTOModel
	{
        public int TotalDraws { get; set; }
        public List<NumberFrequencyDTOModel> NumbersFrequency { get; set; }
	}
}

/*Example of JSON response from the API for numbers frequency:
 {
    "totalDraws": 149,
    "numberFrequrency": [
        {
            "number": 10,
            "numberOfOccurrences": 25,
            "percentOfOccurrences": 17
        },
        {
            "number": 4,
            "numberOfOccurrences": 9,
            "percentOfOccurrences": 6
        }
    ],
    "numberSpecialFrequrency": null
} 
 */