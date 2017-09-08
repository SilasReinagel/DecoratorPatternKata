namespace DecoratorPattern.App
{
    public interface BeverageIngredient
    {
        string Description { get; }
        decimal Price { get; }
        int Calories { get; }
    }
}
