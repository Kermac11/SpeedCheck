using System;

namespace SpeedCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedMeasurementCatalog catalog = new SpeedMeasurementCatalog("Maglegårdvej 2, 4000", "by", 50);

            catalog.AddSpeedMeasurement(50);
            catalog.AddSpeedMeasurement(60);
            catalog.AddSpeedMeasurement(70);
            catalog.AddSpeedMeasurement(90);
            catalog.AddSpeedMeasurement(300);


            try
            {
                catalog.AddSpeedMeasurement(301);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                catalog.AddSpeedMeasurement(-20);
           
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                catalog.AddSpeedMeasurement(110);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(catalog.AverageSpeed());

            Console.WriteLine(catalog.ToString());


            //test of NoOfOverSpeedLimit
            Console.WriteLine("\n");
            Console.WriteLine(catalog.NoOfOverSpeedLiimit());

            //test of NoOfOverSpeedLimit
            Console.WriteLine("\n");
            Console.WriteLine(catalog.NoOfCutinLicences());

            //test of NoOfConditionalRevocations
            Console.WriteLine("\n");
            Console.WriteLine("Conditional Revocations: " + catalog.NoOfConditionalRevocations());

            //test of NoOfConditionalRevocations
            Console.WriteLine("\n");
            Console.WriteLine("Unconditional Revocations: " + catalog.NoOfunconditionalRevocations());
        }
    }
}
