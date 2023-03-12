namespace BehavioralDesignPattern.Template
{
    public abstract class Pizza
    {
        /* template pattern allows us to group by related objects with the same algorithm 
         * by creating a base class and allowing subclasses to define its implementation or logic without changing the algorithms structure.
         * we should use template pattern when there are objects that has the same algorithm or steps to perform but has different implementations.
         * so that we can centralized the algorithm or steps execution
        */
        public void CreatePizza()
        {
            CreateDough();
            AddCheese();
            CookPizza();
            ServePizza();
        }

        protected abstract void CreateDough();
        protected abstract void AddCheese();

        protected abstract void CookPizza();
        protected abstract void ServePizza();

    }
}