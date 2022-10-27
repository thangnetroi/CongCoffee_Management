using System;
using System.IO;
using ManageCoffee.Interface;

namespace ManageCoffee.Classes
{
    public class Coffee : InforCoffee
    {
        private int idCoffee;
        private string name;
        private string temp;
        private string cafein;
        private double rate;
        private string price;


        public Coffee(int idCoffee, string name, string temp, string cafein, double rate, string price)
        {
            this.IdCoffee = idCoffee;
            this.Name = name;
            this.Temp = temp;
            this.Cafein = cafein;
            this.Rate = rate;
            this.Price = price;
        }



        public int IdCoffee { get => idCoffee; set => idCoffee = value; }
        public string Name { get => name; set => name = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Cafein { get => cafein; set => cafein = value; }
        public virtual double Rate
        {
            get => rate;
            set => rate = value;
        }
        public string Price { get => price; set => price = value; }

        
      
        public string ViewInforCoffees()
        {
            return $"{GetType()} \t ID: {IdCoffee} | Name:{Name} | Temp: {temp} | Cafein: {cafein} | Rate: {Rate}% | Price: {Price} \n";

        }

       
    }
}