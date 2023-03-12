using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Strategy
{
    public class PizzaContext
    {
        private readonly PizzaProvider _pizzaProvider;

        public PizzaContext(PizzaProvider pizzaProvider)
        {
            _pizzaProvider = pizzaProvider;
        }

        public void BakePizza()
        {
            _pizzaProvider.CreatePizza();
        }
    }
}
