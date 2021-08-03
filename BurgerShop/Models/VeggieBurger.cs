using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Models
{
    class VeggieBurger : Burger
    {
        private const string VEGGIE_PATTY = "Veggie Patty";
        private String mushrooms;
        private String lettuce;

        public VeggieBurger()
            : base()
        {
        }

        public VeggieBurger(string bun, string mushrooms, string lettuce)
            : base()
        {
            base.Bun = bun;
            base.Patty = VEGGIE_PATTY;
            this.mushrooms = mushrooms;
            this.lettuce = lettuce;
        }

        public override string Patty { get => base.Patty; }
        public string Mushrooms { get => mushrooms; set => mushrooms = value; }
        public string Lettuce { get => lettuce; set => lettuce = value; }
    }
}
