using LottoApp.Services;

namespace Lotto.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var Lotto = new HttpClientService();

			var result = Lotto.GetResults(2, 3);

			Assert.NotNull(result);
			Assert.Equal(6, result);

		}

		[Theory]
		[InlineData(2, 3)]
		[InlineData(4, 5)]
		public void Test2(int a, int b)
		{
			var Lotto = new HttpClientService();
			
			var result = Lotto.GetResults(a, b);

			Assert.NotNull(result);
			Assert.Equal(a*b, result);

		}

	}
}
