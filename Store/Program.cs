using System;

namespace Store
{

    interface ITotalPrice
    {

        double getItems();
        void showItems();

    }


    public class Goods : ITotalPrice
    {
        private double items;

        public Goods()
        {
          items = 0.0;
            
        }


        public Goods(double i)
        {

            items = i;
        }


        public double getItems()
        {
            return items;

        }

      public void showItems()
        {
            Console.WriteLine(getItems());
        }

    }










    class Program
    {
        static void Main(string[] args)
        {
            Goods eggs = new Goods(2.99);
            Goods bread = new Goods(1.99);
            Goods soda = new Goods(5.99);
            Console.WriteLine("My Items For Sale");
           
            
            


        }
    }
}
