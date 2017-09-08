using DecoratorPattern.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPattern.Tests
{
    [TestClass]
    public class CustomizedBeverageUnitTests
    {
        // Sample Nutrition Information: https://www.starbucks.com/menu/drinks
        // Sample Price List: https://www.fastfoodmenuprices.com/starbucks-prices/

        [TestMethod]
        public void CustomizedBeverage_VentiLatte()
        {
            var drink = new Latte(Size.Venti);

            AssertDescriptionContains(drink, "Venti", "Size");
            AssertDescriptionContains(drink, "Latte", "Drink Name");
            Assert.AreEqual(240, drink.Calories);
            Assert.AreEqual(4.15m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_TallSoyCaramelMacchiatoWithExtraWhip()
        {
            var drink = new WithWhipCream(WhipCream.Extra, new WithSoyMilk(new CaramelMacchiatto(Size.Tall)));

            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Soy", "Milk type");
            AssertDescriptionContains(drink, "Caramel Macchiato", "Drink Name");
            AssertDescriptionContains(drink, "Extra Whip", "Whip Cream type");
            Assert.AreEqual(194, drink.Calories);
            Assert.AreEqual(3.75m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_TallCoffeeFrappuccinoWithNoWhip()
        {
            var drink = new WithWhipCream(WhipCream.None, new Frappuccino(Size.Tall));
            
            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Frappuccino", "Drink Name");
            AssertDescriptionContains(drink, "No Whip", "Whip Cream type");
            Assert.AreEqual(180, drink.Calories);
            Assert.AreEqual(3.25m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_TallHazelnutMochaFrappuccino()
        {
            var drink = new WithFlavor(Flavor.Hazelnut, new Frappuccino(Size.Tall));

            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Frappuccino", "Drink Name");
            AssertDescriptionContains(drink, "Hazelnut", "Flavoring");
            Assert.AreEqual(185, drink.Calories);
            Assert.AreEqual(3.75m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_WithActiveDiscountForRaspberryFlavoring_TallRaspberryFrappuccino_CostsSameAsTallCoffeeFrappuccino()
        {
            var drink = new WithDiscount(Flavor.Raspberry, new WithFlavor(Flavor.Raspberry, new Frappuccino(Size.Tall)));

            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Frappuccino", "Drink Name");
            AssertDescriptionContains(drink, "Raspberry", "Flavoring");
            Assert.AreEqual(185, drink.Calories);
            Assert.AreEqual(3.25m, drink.Price);
        }

        private void AssertDescriptionContains(Beverage drink, string term, string context)
        {
            Assert.IsTrue(drink.Description.Contains(term), $"Description does not include {context}: '{term}'");
        }
    }
}
