using System;

namespace Task3
{

    class Converter
    {
        double usd;
        double eur;
        public Converter(double USD, double EUR)
        {
            usd = USD;
            eur = EUR;
        }
        public double UAHUSD(double UAH) {
            return UAH / usd;
        }
        public double USDUAH(double USD)
        {
            return USD * usd;
        }
        public double UAHEUR(double UAH)
        {
            return UAH / eur;
        }
        public double EURUAH(double EUR)
        {
            return EUR * eur;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter curr = new Converter(26.53, 30.83);
            Console.WriteLine("Input trading pair (UAHUSD,USDUAH,UAHEUR,EURUAH)");
            string input = Console.ReadLine();
            Console.WriteLine("Input and an amount:");
            int val = int.Parse(Console.ReadLine());
            switch (input)
            {
                case "UAHUSD":
                    Console.WriteLine(curr.UAHUSD(val));
                    break;
                case "USDUAH":
                    Console.WriteLine(curr.USDUAH(val));
                    break;
                case "UAHEUR":
                    Console.WriteLine(curr.UAHEUR(val));
                    break;
                case "EURUAH":
                    Console.WriteLine(curr.EURUAH(val));
                    break;
            }
        }
    }
}
