using System;
using System.Globalization;
using System.Text;
using ManageCoffee.Classes;
using Coffee_Management;

namespace ManageCoffee
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MenuCoffee();
        }
        private static void MenuCoffee()
        {
            int choice;
            CoffeeShop coffeeshop = new CoffeeShop();

            coffeeshop.AddCoffee(new Coffee(1,"Cafe Muoi","Lanh","High",3.8,"35.000"));
            coffeeshop.AddCoffee(new Coffee(2, "Vina-Cappu", "Lanh", "High", 4.5, "35.000"));
            coffeeshop.AddCoffee(new Coffee(3, "Vina-Cano", "Lanh", "High", 4.2, "35.000"));
            coffeeshop.AddCoffee(new BestSeller(4, "Coconut Coffee", "Lanh", "High", 4.8, "35.000"));
            coffeeshop.AddCoffee(new BestSeller(5, "Bac xiu", "Lanh", "High", 4.8, "35.000"));
            coffeeshop.AddCoffee(new BestSeller(6, "Cafe sua da Sai Gon", "Lanh", "High", 5, "35.000"));
            coffeeshop.AddCoffee(new BestSeller(7, "Vina-Latte", "Lanh", "High", 4.9, "35.000"));
            coffeeshop.AddCoffee(new BestSeller(8, "Vina-Cappu", "Lanh", "High", 4.8, "35.000"));
            
            
            while (true)
            {
                Console.WriteLine("-------+ CONG COFFEE MANAGEMENT +------");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("|   1. Add New Coffee                 |");
                Console.WriteLine("|   2. View List Coffees              |");
                Console.WriteLine("|   3. Update Coffee Information      |");
                Console.WriteLine("|   4. Search Coffee By Id            |");
                Console.WriteLine("|   5. Delete Coffee By Id            |");
                Console.WriteLine("|   6. Exit                           |");
                Console.WriteLine("---------------------------------------");
                Console.Write(" ** Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                int id;
                switch (choice)
                {
                    case 1:

                        while (true)
                        {
                            Console.WriteLine(" m: To Add Normal Coffee");
                            Console.WriteLine(" h: To Add Best Seller");
                            Console.WriteLine(" e: To Back Main Menu");
                            Console.WriteLine("Please choose option you want to add coffee: ");
                            string option = Console.ReadLine();
                            if (option.Equals("m"))
                            {
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter the coffee name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter temp: ");
                                string temp = Console.ReadLine();
                                Console.Write("Enter cafein: ");
                                string cafein = Console.ReadLine();
                                Console.Write("Enter rate: ");
                                double rate = Double.Parse(Console.ReadLine());
                                Console.Write("Enter price: ");
                                string price = Console.ReadLine();
                                coffeeshop.AddCoffee(new Coffee(id, name, temp, cafein, rate, price));

                            }else if (option.Equals("h"))
                            {
                                Console.Write("Enter Id: ");
                                id = int.Parse(Console.ReadLine());
                                Console.Write("Enter the coffee name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter temp: ");
                                string temp = Console.ReadLine();
                                Console.Write("Enter cafein: ");
                                string cafein = Console.ReadLine();
                                Console.Write("Enter rate: ");
                                double rate = Double.Parse(Console.ReadLine());
                                Console.Write("Enter price: ");
                                string price = Console.ReadLine();
                                coffeeshop.AddCoffee(new BestSeller(id, name, temp, cafein, rate, price));
                            }
                            else if (option.Equals("e"))
                            {
                                break;
                            }

                        }
                       
                        break;
                    case 2:
                        Console.WriteLine(coffeeshop.ViewInforCoffees());
                        break;
                    case 3:
                        Console.Write("Enter Id: ");
                        id = int.Parse(Console.ReadLine());
                       Console.WriteLine(coffeeshop.UpdateCoffeeByID(id));
                        break;
                    case 4:
                        Console.Write("Enter Id: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(coffeeshop.SearchCoffeeByID(id));
                        break;
                    case 5:
                        Console.Write("Enter Id: ");
                       id = int.Parse(Console.ReadLine());
                        coffeeshop.DeleteCoffeeByID(id);
                      
                        break;
                    case 6:
                       return;
                        break;
                  
                }
            }
            
        }
        
    }
}