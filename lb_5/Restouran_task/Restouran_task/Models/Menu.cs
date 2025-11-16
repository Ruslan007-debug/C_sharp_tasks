using Restouran_task.Abstracrion;
using Restouran_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restouran_task.Models
{
    public class Menu: IMenu
    {
        public List<Position> Dishes { get; set; }

        public void GetMenu()
        {
            Console.WriteLine("All menu: ");
            foreach (var dish in Dishes)
            {
                if (dish is Drink)
                {
                    var drink = dish as Drink;
                    Console.WriteLine($"{drink.Name}, \tCost: {drink.Cost} hrn, \tVolume: {drink.Weight} ml, " +
                        $"\tAlcohol: {drink.Alcohol}, \tTemparature: {drink.Temparature}, \tTaste: {drink.Taste}");
                }
                else if (dish is Food)
                {
                    var food = dish as Food;
                    Console.WriteLine($"{food.Name}, \tCost: {food.Cost} hrn, \tVolume: {food.Weight} gr, " +
                        $"\tType: {food.Type}, \tCoutry: {food.Country}, \tCalories: {food.Calories}");
                }
            }

        }
        public void GetDish(string name)
        {
            foreach (var dish in Dishes)
            {
                if (dish.Name == name && dish is Drink)
                {
                    var drink = dish as Drink;
                    Console.WriteLine($"{drink.Name}, \tCost: {drink.Cost} hrn, \tVolume: {drink.Weight} ml, " +
                        $"\tAlcohol: {drink.Alcohol}, \tTemparature: {drink.Temparature}, \tTaste: {drink.Taste}");
                }
                else if (dish.Name == name && dish is Food)
                {
                    var food = dish as Food;
                    Console.WriteLine($"{food.Name}, \tCost: {food.Cost} hrn, \tVolume: {food.Weight} gr, " +
                        $"\tType: {food.Type}, \tCoutry: {food.Country}, \tCalories: {food.Calories}");
                }
            }
        }
        public void AddToMenu(Position dish)
        {
            Dishes.Add(dish);
            Console.WriteLine($"Added to menu: {dish.Name}");
        }
        public void DeleteFromMenu(Position dish)
        {
            Dishes.Remove(dish);
            Console.WriteLine($"Deleted from menu: {dish.Name}");
        }
    }
}
