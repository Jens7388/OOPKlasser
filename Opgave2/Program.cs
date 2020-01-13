using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = default;
            Car secondCar = default;
            Car thirdCar = default;
            //Hvis prisen er under 1 kr får brugeren en fejlbesked
            try
            {
                firstCar = new Car("Dacia", "Logan", "Beige", 170000, false);
                secondCar = new Car("Toyota", "Yaris", "Rød", 89000, true);
                thirdCar = new Car("Honda", "Civic", "Hvid", 199000, false);
                //firstCar.PutOnSale();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(firstCar);
            Console.WriteLine(secondCar);
            Console.WriteLine(thirdCar);
            Console.ReadLine();
        }
    }
}
