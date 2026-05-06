using System.Threading.Tasks;
using Xunit;
using LottoApp.Services.APIServices;
using LottoApp.Models.DomainModels;

namespace Lotto.Tests
{
    public class TestGetNumbersFrequency
    {
        [Fact]
        public async Task GetNumbersFrequency_ReturnsModel()
        {
            // Act
            NumbersFrequencyModel result = await GetNumbersFrequency.Get();

            // Assert
            Assert.NotNull(result);
            // Optionally, check for expected properties (example):
            Assert.True(result.TotalDraws >= 0);
            Assert.NotNull(result.NumbersFrequency);
        }
    }
}
