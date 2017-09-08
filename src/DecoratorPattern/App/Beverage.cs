namespace DecoratorPattern.App
{
    public interface Beverage
    {
        string Description { get; }
        decimal Price { get; }
        int Calories { get; }
    }
}
