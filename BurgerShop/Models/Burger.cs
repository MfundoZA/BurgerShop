using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerShop.Models
{
    public abstract class Burger
    {
        private String bun;
        private String patty;

        public Burger()
        {
        }

        public Burger(string bun, string patty)
        {
            this.bun = bun;
            this.patty = patty;
        }

        public string Bun { get => bun; set => bun = value; }
        public virtual string Patty { get => patty; set => patty = value; }
    }
}
