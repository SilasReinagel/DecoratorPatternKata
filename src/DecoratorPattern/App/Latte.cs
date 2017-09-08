
namespace DecoratorPattern.App
{
    public class Latte : Beverage
    {
        private readonly Size _size;

        public string Description => $"{_size.Description} Latte";
        public decimal Price => 2.15m + _size.Ounces * .10m;
        public int Calories => _size.Ounces * 12;

        public Latte(Size size)
        {
            _size = size;
        }
    }
}
