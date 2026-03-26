using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LottoApp.Common
{
	internal static class BuildConfig
	{
		public static IConfiguration GetAppsettingsConfig()
		{
			IConfigurationBuilder builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
#if DEBUG
			builder.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);
#endif

			return builder.Build();
		}
	}
}
