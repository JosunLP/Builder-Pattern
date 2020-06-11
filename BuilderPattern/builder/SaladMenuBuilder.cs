using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.builder
{
    class SaladMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();

        public override void BuildBurgerOtSalad()
        {
            _menu.Add("Salad");
        }

        public override void BuildFries()
        {
            _menu.Add("Fries");
        }

        public override void BuildDessert()
        {
            _menu.Add("Dessert");
        }

        public override void BuildDrink()
        {
            _menu.Add("Drink");
        }

        public override void BuildToy()        {}

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}
