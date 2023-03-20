namespace Taxi
{
    class program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "dimas";
            taxi.onDuty = false; taxi.onDuty = true;
            taxi.numPassanger = 123456789;


            taxi.info();
            taxi.naik();
            taxi.turun();

            Console.ReadKey();
        }
    }
}
