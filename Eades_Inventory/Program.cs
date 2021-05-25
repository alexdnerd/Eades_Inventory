using System;

namespace Eades_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleKeyInfo keypress;
            //Bicycle p1 = new Bicycle;

            Shipper shipperObject = new Shipper;


            do
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                keypress = Console.ReadKey();
                if (keypress.KeyChar == '1')
                {
                    Console.Clear();
                    Bicycle.P
                    Shipper.Add
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();


                }
                else if (keypress.KeyChar == '2')
                {
                    Console.Clear();
                    



                }
                else if (keypress.KeyChar == '3')
                {
                    Console.Clear();
                    
                }
                else if (keypress.KeyChar == '4')
                {
                    Console.Clear();

                }
                else if (keypress.KeyChar == '5')
                {
                    Console.Clear();
                    Console.WriteLine("Shipment manifest:");
                    if (Shipper.bicycleCounter)


                }
                else if (keypress.KeyChar == '6')
                {
                    Console.Clear();
                    Console.WriteLine("Total shipping cost for this order is $");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                    Console.Clear();

                }
                
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option, try again!");
                }
            } while (keypress.KeyChar != '1' || keypress.KeyChar != '2' || keypress.KeyChar != '3' || keypress.KeyChar != '4' || keypress.KeyChar != '5' || keypress.KeyChar != '6');
        }
    }
}
