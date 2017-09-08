
namespace DecoratorPattern.App
{
    public class Size
    {
        public string Description { get; }
        public int Ounces { get; }

        public Size(string description, int ounces)
        {
            Description = description;
            Ounces = ounces;
        }

        public static Size Tall = new Size("Tall", 12);
        public static Size Venti = new Size("Venti", 20);
    }
}
