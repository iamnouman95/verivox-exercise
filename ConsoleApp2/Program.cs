using Exercise;

Console.Write("Enter Annual consumption: ");
double.TryParse(Console.ReadLine(), out var consumption);
var productComparison = new ProductComparison();

foreach (var item in productComparison.Compare(consumption))
{
    item.Print();
}
