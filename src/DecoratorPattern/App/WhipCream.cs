
namespace DecoratorPattern.App
{
    public class WhipCream
    {
        public string Description { get; }
        public int Calories { get; }

        public WhipCream(string description, int calories)
        {
            Description = description;
            Calories = calories;
        }

        public static WhipCream None = new WhipCream("No Whip Cream", 0);
        public static WhipCream Normal = new WhipCream("Whip Cream", 10);
        public static WhipCream Extra = new WhipCream("Extra Whip Cream", 20);
    }
}
