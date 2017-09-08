namespace DecoratorPattern.App
{
    public class WithDiscount : Beverage
    {
        private readonly BeverageIngredient _componentToDiscount;
        private readonly Beverage _base;

        public WithDiscount(BeverageIngredient componentToDiscount, Beverage _base)
        {
            _componentToDiscount = componentToDiscount;
            this._base = _base;
        }

        public string Description => $"{_base.Description}";

        public decimal Price => _base.Price - _componentToDiscount.Price;
        public int Calories => _base.Calories;
    }
}
