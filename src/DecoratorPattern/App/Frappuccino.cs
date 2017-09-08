
namespace DecoratorPattern.App
{
    public class Frappuccino : Beverage
    {
        private readonly Size _size;

        public string Description => $"{_size.Description} Coffee Frappuccino";
        public decimal Price => 0.85m + _size.Ounces * 0.20m;
        public int Calories => _size.Ounces * 15;

        public Frappuccino(Size size)
        {
            _size = size;
        }
    }
}
