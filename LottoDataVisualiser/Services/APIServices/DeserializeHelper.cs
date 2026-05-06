using LottoApp.Models.DomainModels;
using LottoApp.Models.DTOs;
using System.Text.Json;

namespace LottoApp.Services.APIServices
{
	internal static class DeserializeHelper
	{
		/// <summary>
		/// This method tries to deserialize provided JSON string into a list of DrawDTOModel objects. If it fails, it catches the exception, updates the json string with the error message, and creates a new GameDrawModel with the error information. It then returns false.
		/// </summary>
		public static bool JsonToDto(string json, ref List<DrawDTOModel> dto, ref GameDrawModel lastLottoDraw)
		{
			try
			{
				dto = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

				if (dto == null || dto.Count == 0)
				{
					json = "Bad api response could not map data:" + json;
					lastLottoDraw = new GameDrawModel(json);
					return false;
				}
			}
			catch (Exception ex)
			{
				json = ex.Message + "|json string: " + json;

				lastLottoDraw = new GameDrawModel(json);
				return false;
			}

			return true;
		}
		/// <summary>
		/// This method tries to deserialize provided JSON string into a DrawDTOModel object. If it fails, it catches the exception, updates the json string with the error message, and creates a new GameDrawModel with the error information. It then returns false.
		/// </summary>
		public static bool JsonToDto(string json, ref List<DrawDTOModel> dto, ref List<GameDrawModel> recentGamesDraws)
		{
			try
			{
				dto = JsonSerializer.Deserialize<List<DrawDTOModel>>(json);

				if (dto == null || dto.Count == 0)
				{
					json = "Bad api response could not map data:" + json;
					recentGamesDraws.Add(new GameDrawModel(json));
					return false;
				}
			}
			catch (Exception ex)
			{
				json = ex.Message + " || json string: " + json;

				recentGamesDraws.Add(new GameDrawModel(json));
				return false;
			}

			return true;
		}
		
		public static bool JsonToDto(string json, ref NumbersFrequencyDTOModel dto, ref NumbersFrequencyModel numbersFrequency)
		{
			try
			{
				dto = JsonSerializer.Deserialize<NumbersFrequencyDTOModel>(json);
				if (dto == null || dto.NumbersFrequency == null)
				{
					json = "Bad api response could not map data:" + json;
					numbersFrequency = new NumbersFrequencyModel(json);
					return false;
				}
			}
			catch (Exception ex)
			{
				json = ex.Message + " || json string: " + json;
				numbersFrequency = new NumbersFrequencyModel(json);
				return false;
			}

			return true;
		}
	}
}
