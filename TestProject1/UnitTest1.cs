using Exercise;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
    public class Tests
    {
        private readonly IProductComparison _comparison;

        public Tests()
        {
            _comparison = new ProductComparison();
        }

        [Fact]
        public void Return_Result_When_Consumption_IsValid_Number()
        {
            var consumption = 3500;
            var result = _comparison.Compare(consumption);

            //_configuration.Returns(configuration);

            result.Should().BeEquivalentTo(new List<ProductModel>
            {
                new() { TariffName = "Basic Electricity Tariff", AnnualCostPerYear = 830 },
                new() { TariffName = "Packaged Tariff", AnnualCostPerYear = 800 }
            });
        }

        [Fact]
        public void Return_Result_When_Consumption_IsNegative_Number()
        {
            var consumption = -3500;
            var result = _comparison.Compare(consumption);

            result.Should().BeEquivalentTo(new List<ProductModel>());
        }
    }

}