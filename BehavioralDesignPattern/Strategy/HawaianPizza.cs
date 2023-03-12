using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Strategy
{
    public class HawaianPizza : PizzaProvider
    {
        public override void CreatePizza()
        {
            BakeDough();
            AddCheese();
            AddFruits();
            BakePizza();
            ServePizza();
        }

        protected override void AddCheese()
        {
            Console.WriteLine("added mozurella cheese for hawaiain");
        }

        protected override void BakeDough()
        {
            Console.WriteLine("baked dough for our hawaian pizza");
        }

        protected override void BakePizza()
        {
            Console.WriteLine("baked pizza for hawaian");
        }

        protected override void ServePizza()
        {
            Console.WriteLine("served hawaian pizza");
        }

        private void AddFruits()
        {
            Console.WriteLine("added fruit to hawaian");
        }
    }
}
