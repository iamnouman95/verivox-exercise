namespace Exercise
{
    public interface IProductComparison
    {
        IEnumerable<ProductModel> Compare(double consumption);
    }
}
