using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Template
{
    public class HawaianPizza : Pizza
    {
        protected override void AddCheese()
        {
            Console.WriteLine("Adding cheese for hawaian pizza");
        }

        protected override void CookPizza()
        {
            Console.WriteLine("Cooking hawaian pizza");
        }

        protected override void CreateDough()
        {
            Console.WriteLine("Creating dough for hawaian pizza");
        }

        protected override void ServePizza()
        {
            Console.WriteLine("Serving hawaian pizza");
        }
    }
}
