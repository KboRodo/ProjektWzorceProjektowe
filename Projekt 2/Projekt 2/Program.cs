using System;

namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w naszej burgerowni");
            //wywołanie powiadomienia 
            var stanZamowienia = new Powiadomienia();
            stanZamowienia.ustawStan(new Tworzenie());
            stanZamowienia.alert();

                Console.WriteLine("Zamów burgera (w)");
                Console.WriteLine("Wyjście (e)");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "w":
                        Console.Clear();
                        var burger=dodajBurger();
                        stanZamowienia.ustawStan(new WybieranieFrytki());
                        stanZamowienia.alert();
                        break;

                    case "e":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji, wybierz inny znak");
                        Console.Clear();
                        break;
                }

            stanZamowienia.ustawStan(new Zakonczenie());
            stanZamowienia.alert();
        }
        public static IBurger dodajBurger()
        {
            
            
            Console.WriteLine("Wybierz rozmiar burgera");
            Console.WriteLine("Q-Duży");
            Console.WriteLine("W-Mały");
            string opcja = Console.ReadLine();

            IBurger nowyBurger = null;
            switch (opcja)
            {
                case "q":
                    nowyBurger = new DuzyBurger();
                    break;
                case "w":
                    nowyBurger = new MalyBurger();
                    break;
            }
            return nowyBurger;
        }
            
    }
}
