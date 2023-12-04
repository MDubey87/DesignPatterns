using BuilderDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builder
{
    /// <summary>
    /// Implements the Builder interface to build the product
    /// </summary>
    public class ConcreteMealBuilder : IMealBuilder
    {
        private Meal _meal = new Meal();

        public void AddBurger(string burger)
        {
            _meal.Burger = burger;
        }

        public void AddDrink(string drink)
        {
            _meal.Drink = drink;
        }

        public void AddFries(string fries)
        {
            _meal.Fries = fries;
        }

        public void AddDessert(string dessert)
        {
            _meal.Dessert = dessert;
        }

        public Meal GetMeal()
        {
            return _meal;
        }
    }

}
