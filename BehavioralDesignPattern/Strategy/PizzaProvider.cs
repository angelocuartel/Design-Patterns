using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Strategy
{
    public abstract class PizzaProvider
    {
        
        protected abstract void BakeDough();
        protected abstract void AddCheese();
        protected abstract void BakePizza();
        protected abstract void ServePizza();

        public abstract void CreatePizza();
    }
}
