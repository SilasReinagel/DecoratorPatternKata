
namespace DecoratorPattern.App
{
    public class CaramelMacchiatto : Beverage
    {
        private readonly Size _size;

        public string Description => $"{_size.Description} Caramel Macchiato";
        public decimal Price => 2.55m + _size.Ounces * .10m;
        public int Calories => _size.Ounces * 17;

        public CaramelMacchiatto(Size size)
        {
            _size = size;
        }
    }
}
