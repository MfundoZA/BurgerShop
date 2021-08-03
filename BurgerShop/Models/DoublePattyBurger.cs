using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Models
{
    class DoublePattyBurger : Burger
    {
        private String secondPatty;

        public DoublePattyBurger()
            : base()
        {
        }

        public DoublePattyBurger(string bun, string firstPatty, string secondPatty)
            : base(bun, firstPatty)
        {
            this.secondPatty = secondPatty;
        }

        public string SecondPatty { get => secondPatty; set => secondPatty = value; }
    }
}
