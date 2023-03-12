using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Template
{
    public class PepperoniPizza : Pizza
    {
        protected override void AddCheese()
        {
            Console.WriteLine("Adding cheese for pepperoni pizza");
        }

        protected override void CookPizza()
        {
            Console.WriteLine("Cooking pepperoni pizza");
        }

        protected override void CreateDough()
        {
            Console.WriteLine("Creating dough for pepperoni pizza");
        }

        protected override void ServePizza()
        {
            Console.WriteLine("Serving pepperoni pizza");
        }
    }
}
