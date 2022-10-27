using System;
using ManageCoffee.Classes;

namespace Coffee_Management
{
    public class BestSeller : Coffee
    {
        // public through get set
        public BestSeller(int idCoffee, string name, string temp, string cafein, double rate, string price) :
            base(idCoffee,name, temp, cafein, rate, price)
        {
            
        }

        public override double Rate
        {
            get => (base.Rate * 0.25) + base.Rate;
            set => base.Rate = value;
        }
        

    }
}