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
            // TASK: Replace this with your own drink creation/customization strategy.
            var drink = new VentiLatte();

            AssertDescriptionContains(drink, "Venti", "Size");
            AssertDescriptionContains(drink, "Latte", "Drink Name");
            Assert.AreEqual(250, drink.Calories);
            Assert.AreEqual(4.15m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_TallSoyCaramelMacchiatoWithExtraWhip()
        {
            // TASK: Replace this with your own drink creation/customization strategy.
            var drink = new TallSoyCaramelMacchiatoWithExtraWhip();

            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Soy", "Milk type");
            AssertDescriptionContains(drink, "Caramel Macchiato", "Drink Name");
            AssertDescriptionContains(drink, "Extra Whip", "Whip Cream type");
            Assert.AreEqual(190, drink.Calories);
            Assert.AreEqual(3.75m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_TallCoffeeFrappuccinoWithNoWhip()
        {
            // TASK: Replace this with your own drink creation/customization strategy.
            var drink = new TallCoffeeFrappuccinoWithNoWhip();
            
            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Frappuccino", "Drink Name");
            AssertDescriptionContains(drink, "No Whip", "Whip Cream type");
            Assert.AreEqual(180, drink.Calories);
            Assert.AreEqual(3.25m, drink.Price);
        }

        [TestMethod] public void CustomizedBeverage_TallHazelnutMochaFrappuccino()
        {
            // TASK: Replace this with your own drink creation/customization strategy.
            var drink = new TallHazelnutMochaFrappuccino();

            AssertDescriptionContains(drink, "Tall", "Size");
            AssertDescriptionContains(drink, "Frappuccino", "Drink Name");
            AssertDescriptionContains(drink, "Hazelnut", "Flavoring");
            Assert.AreEqual(185, drink.Calories);
            Assert.AreEqual(3.75m, drink.Price);
        }

        [TestMethod]
        public void CustomizedBeverage_WithActiveDiscountForRaspberryFlavoring_TallRaspberryFrappuccino_CostsSameAsTallCoffeeFrappuccino()
        {
            // ADVANCED TASK: Without need to build the drink differently, apply a free single Raspberry Syrup discount using decoration
            var drink = new TallRaspberryFrappuccino();

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

        #region TASK: Remove all of these
        private class TallHazelnutMochaFrappuccino : Beverage
        {
            public string Description => "Tall Hazelnut Coffee Frappuccino";
            public decimal Price => 3.75m;
            public int Calories => 185;
        }

        private class TallRaspberryFrappuccino : Beverage
        {
            public string Description => "Tall Raspberry Coffee Frappuccino";
            public decimal Price => 3.25m;
            public int Calories => 185;
        }

        private class TallCoffeeFrappuccinoWithNoWhip : Beverage
        {
            public string Description => "Tall Coffee Frappuccino No Whip";
            public decimal Price => 3.25m;
            public int Calories => 180;
        }

        private class TallSoyCaramelMacchiatoWithExtraWhip : Beverage
        {
            public string Description => "Extra Whip Soy Tall Caramel Macchiato";
            public decimal Price => 3.75m;
            public int Calories => 190;
        }

        private class VentiLatte : Beverage
        {
            public string Description => "Venti Caffe Latte";
            public decimal Price => 4.15m;
            public int Calories => 250;
        }
        #endregion
    }
}
