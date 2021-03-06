﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.builder
{
    abstract class MenuBuilder
    {
        public abstract void BuildBurgerOrSalad();

        public abstract void BuildFries();

        public abstract void BuildDessert();

        public abstract void BuildDrink();

        public abstract void BuildToy();

        public abstract Menu GetResult();
    }
}
