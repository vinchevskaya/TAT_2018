using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the desired characteristics: ");
            Console.WriteLine("1: Mark | (Lada, Jaguar, Lexus)");
            Console.WriteLine("2: Model");
            Console.WriteLine("3: BodyType | (Sedan, SUV)");
            Console.WriteLine("4: Transmission | (Automatic, Manual)");
            Console.WriteLine("5: EngineType | (Gasoline, Diesel, Electric)");
            Console.WriteLine("6: Amount");
            Console.WriteLine("7: Power");
            Console.WriteLine("8: ClimateManagement | (ClimateControle, Conditioner, Null)");
            Console.WriteLine("9: InteriorType | (Leather, Fabric, Combined)");

            string mark = Console.ReadLine();
            string model = Console.ReadLine();
            string bodyType = Console.ReadLine();
            string transmissionType = Console.ReadLine();
            string engineType = Console.ReadLine();
            string amount = Console.ReadLine();
            string power = Console.ReadLine();
            string climateManagement = Console.ReadLine();
            string interiorType = Console.ReadLine();

            //ICars cars = new Jaguar("XE", "sedan", "revel", "", "", "", "", "leather");
            string stock = "Catalog.json";
            ICreator creator = new JaguarCreator("Jaguar", "XE", "sedan", "automatic", "", "", "", "", "leather");
            creator.CarsCreator();
            JSONreader Reader = new JSONreader(stock);
            Reader.ReadToObjectJson();
        }
    }
}
