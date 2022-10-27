using System;
using System.Collections.Generic;
using System.Linq;
using ManageCoffee.Classes;
using ManageCoffee.Interface;

namespace Coffee_Management
{
    public class CoffeeShop : InforCoffee
    {
        private static List<Coffee> coffees = new List<Coffee>();


        public void AddCoffee(Coffee coffee)
        {
            coffees.Add(coffee);
        }

        public string SearchCoffeeByID(int id)
        {
            Coffee coffee = coffees.FirstOrDefault(i => i.IdCoffee.Equals(id));
            if (coffee != null)
            {
                return coffee.ViewInforCoffees();

            }

            return "The is no coffee have this id";
        }

        public string ViewInforCoffees()
        {
            string resu = "";
            foreach (var m in coffees)
            {
                resu = resu + m.ViewInforCoffees();
            }

            return resu;
        }
        public void DeleteCoffeeByID(int id)
        {
            Coffee coffee = coffees.FirstOrDefault(i => i.IdCoffee.Equals(id));
            {
                if (coffee != null)
                {
                    coffees.Remove(coffee);
                    Console.WriteLine("Remove successfully!");
                }
                else
                {
                    Console.WriteLine("Please enter ID again!!");
                }

            }
        }
        public bool UpdateCoffeeByID(int id)
        {
            Coffee coffee = coffees.FirstOrDefault(i => i.IdCoffee.Equals(id));
            if (coffee != null)
            {
                Console.Write("Enter the coffee name: ");
                coffee.Name = Console.ReadLine();
                Console.Write("Enter temp: ");
                coffee.Temp = Console.ReadLine();
                Console.Write("Enter cafein: ");
                coffee.Cafein = Console.ReadLine();
                Console.Write("Enter rate: ");
                coffee.Rate = Double.Parse(Console.ReadLine());
                Console.Write("Enter price: ");
                coffee.Price = Console.ReadLine();
                Console.WriteLine("Update successfully!");
                return true;
            }

            return false;
        }
    }
}