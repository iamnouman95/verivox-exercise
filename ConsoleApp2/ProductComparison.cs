namespace Exercise
{
    public class ProductComparison : IProductComparison
    {
        private readonly string _basicTariffTitle = "Basic Electricity Tariff";
        private readonly string _packagedTariffTitle = "Packaged Tariff";

        public IEnumerable<ProductModel> Compare(double consumption)
        {
            if (consumption < 0) return new List<ProductModel>();
            var resultModel = new List<ProductModel>
            {
                ProductA(consumption), ProductB(consumption)
            }.OrderBy(x => x.AnnualCostPerYear);

            return resultModel;
        }

        private ProductModel ProductA(double consumption)
        {
            return MapToProductModel(_basicTariffTitle, (5 * 12) + (consumption * 0.22));
        }

        private ProductModel ProductB(double consumption)
        {
            return consumption <= 4000 
                ? MapToProductModel(_packagedTariffTitle, 800)
                : MapToProductModel(_packagedTariffTitle, 800 + (consumption - 4000) * 0.30);
        }

        private ProductModel MapToProductModel(string tariffName, double consumption)
        {
            return new() { TariffName = tariffName, AnnualCostPerYear = consumption };
        }
    }
}
