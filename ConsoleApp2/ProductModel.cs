namespace Exercise
{
    public class ProductModel
    {
        public string? TariffName { get; set; }
        public double AnnualCostPerYear { get; set; }

        public void Print()
        {
            Console.WriteLine("TariffName: " + TariffName);
            Console.WriteLine("AnnualCost: " + AnnualCostPerYear);
        }
    }
}
