namespace DecoratorPattern.App
{
    public class WithWhipCream : Beverage
    {
        private readonly Beverage _base;
        private readonly WhipCream _whipCream;

        public WithWhipCream(WhipCream whipCream, Beverage _base)
        {
            this._base = _base;
            _whipCream = whipCream;
        }

        public string Description => $"{_base.Description} {_whipCream.Description}";

        public decimal Price => _base.Price;
        public int Calories => _base.Calories + _whipCream.Calories;
    }
}
