using LottoApp.Models.DomainModels;
using LottoApp.Models.DTOs;
using LottoApp.Services.EndPointWrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LottoApp.Services.APIServices
{
	public class GetNumbersFrequency
	{
		public static async Task<NumbersFrequencyModel> Get()
		{
			string json = await GetApiResponse();
			
			NumbersFrequencyDTOModel numbersFrequencyDTO = new();

			NumbersFrequencyModel numbersFrequency = new();

			if (!DeserializeHelper.JsonToDto(json, ref numbersFrequencyDTO, ref numbersFrequency))
			{
				return numbersFrequency;
			}

			return numbersFrequency;
		}

		private static async Task<string> GetApiResponse()
		{
			return await new EndPointWrappers.NumbersFrequency().Get();
		}
	}
}

