using BuilderPattern.builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.director
{
    class MenuDirector
    {
        public void Construct(MenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDessert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}
