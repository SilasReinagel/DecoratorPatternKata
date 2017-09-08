namespace DecoratorPattern.App
{
    public class WithSoyMilk: Beverage
    {
        private readonly Beverage _base;

        public WithSoyMilk(Beverage _base)
        {
            this._base = _base;
        }

        public string Description => $"Soy {_base.Description}";

        public decimal Price => _base.Price;
        public int Calories =>_base.Calories - 30;
    }
}
