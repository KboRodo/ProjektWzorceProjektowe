using System;
using System.Collections.Generic;

namespace SalonSamochodowy
{
    class Program
    {
        static void Main(string[] args)
        {
            //opcja 1-tworzenie samochodu-menu z wyborem opcji samochodu + opcja wyjscia->menu z wyborem opcji dodatkowych+opcja cofniecia sie
            //->wyswietlenie samochodu i zapisanie go w liscie
            //wypisywanie wszystkich dodanych samochodów samochodów

            Console.WriteLine("Witaj w Salonie Samochodowym");
            bool menuon = true;
            List<Samochod> samochodyLista = new List<Samochod>();

            while (menuon)
{
                Console.WriteLine("Stwórz nowy samochód  (s)");
                Console.WriteLine("Pokaż stworzone zamochody (u)");
                Console.WriteLine("Wyjście (e)");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "s":
                        Console.Clear();
                        samochodyLista.Add(dodajSamochod());
                        //opcjawBudowie();
                        //statement
                        break;

                    case "u":
                        Console.Clear();
                        pokazSamochodyLista(samochodyLista);
                        //Console.WriteLine("Jeśli chcesz wrócić wciśnij a");
                        break;

                    case "e":
                        Environment.Exit(0);
                        break;
                        //menuon false

                    default:
                        Console.WriteLine("Nie ma takiej opcji, wybierz inny znak");
                        Console.Clear();
                        //wyswietlic ze nie ma takiej opcji i pobrac znak na nowo
                        menuon = false;
                        break;
                }
            }


        }
        public static void pokazSamochodyLista(List<Samochod> samochodyLista)//f-cja wyswietlajaca wszystkie samochody
        {
            Console.Clear();
            Console.WriteLine("Lista stworzonych samochodów");
            foreach (Samochod item in samochodyLista)
            {
               Parametry param = item.stworzSamochod();
               Console.WriteLine(param.zwroc());
            }
        }
        public static Samochod dodajSamochod()//f-cja dodajaca samochod
        {
            Samochod nowySamochod=null;

            Console.WriteLine("Wybierz rodzaj samochodu");
            Console.WriteLine("Q-SUV, W-VAN, E-SEDAN, F-KOMBI");
            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "q":
                    nowySamochod =  Samochod.wybierzSamochod(TYP.SUV);
                    break;
                case "w":
                    nowySamochod =  Samochod.wybierzSamochod(TYP.VAN);
                    break;
                case "e":
                    nowySamochod =  Samochod.wybierzSamochod(TYP.SEDAN);
                    break;
                case "f":
                    nowySamochod =  Samochod.wybierzSamochod(TYP.KOMBI);
                    break;

            }
            return nowySamochod;
        }
    }
}

