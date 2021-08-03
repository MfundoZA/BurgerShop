using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Models
{
    class CheeseBurger : Burger
    {
        private String cheese;

        public CheeseBurger()
            : base()
        {

        }

        public CheeseBurger(string bun, string patty, string cheese)
            : base(bun, patty)
        {
            this.cheese = cheese;
        }

        public string Cheese { get => cheese; set => cheese = value; }
    }
}
