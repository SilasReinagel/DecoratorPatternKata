namespace DecoratorPattern.App
{
    public class WithFlavor : Beverage
    {
        private readonly Flavor _flavor;
        private readonly Beverage _base;

        public WithFlavor(Flavor flavor, Beverage _base)
        {
            _flavor = flavor;
            this._base = _base;
        }

        public string Description => $"{_flavor.Description} {_base.Description}";

        public decimal Price => _base.Price + _flavor.Price;
        public int Calories => _base.Calories + _flavor.Calories;
    }
}
