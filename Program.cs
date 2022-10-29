namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  Фабричній метод*/

            /*определились с моделью*/
            ModelFactory factory = new ToyotaFactory();

            /*создали завод ,решили в нем тойоті производить*/
            CarFactory cf = new CarFactory(factory);

            List<Cabriolet> cabriolets = new List<Cabriolet>();
            List<Sedan> sedans = new List<Sedan>();


            /*сделали 5 седанов и кабриолетов*/
            for (int i = 10; i < 15; i++)
            {
                cabriolets.Add(cf.CreateCabriolet(i,new Engine(i),new Wheel(i)));
                sedans.Add(cf.CreateSedan(new Engine(i),new Wheel(i)));
            }

            foreach (var item in cabriolets)
            {
                Console.WriteLine(item);
            } 
            foreach (var item in sedans)
            {
                Console.WriteLine(item);
            }



        }
    }
}