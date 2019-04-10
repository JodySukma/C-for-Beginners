using System;

namespace Selection_5
{
    public partial class Condisional
    {
        public void Hour()
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's Morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's Afternoon");
            else
                Console.WriteLine("It's Evening");
        }

        public void CustomerState()
        {
            bool isGoldCustomer = true;


            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            // setelah disederhanakan
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}
