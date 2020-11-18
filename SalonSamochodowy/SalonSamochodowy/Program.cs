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
            List<Opcje> samochodyLista = new List<Opcje>();

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
                        Samochod samochod = dodajSamochod();
                        Parametry typSamochodu = samochod.stworzSamochod();
                        Opcje samochodLakier = wybierzKolor(typSamochodu);
                        Opcje samochodAkcesoria =wybierzAkcesoria(samochodLakier);
                        samochodyLista.Add(samochodAkcesoria);
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
        public static void pokazSamochodyLista(List<Opcje> samochodyLista)//f-cja wyswietlajaca wszystkie samochody
        {
            Console.Clear();
            Console.WriteLine("Lista stworzonych samochodów");
            int licznik = 1;
            foreach (Opcje item in samochodyLista)
            {
                Console.WriteLine($"{licznik}. {item.zwrocNazwa()}, {item.zwrocCena()}zł ");
                licznik++;
            }
            Console.WriteLine(" ");
        }
        public static Samochod dodajSamochod()//f-cja dodajaca samochod
        {
            // var samochod=new fotele(new czerwoy(new suv())));
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
        public static Opcje wybierzKolor(Parametry samochod)
        {
            Console.Clear();
            Console.WriteLine($"Obecna konfiguracja :{samochod.zwrocNazwa()}, cena:{samochod.zwrocCena()}zł");
            Console.WriteLine("Wybierz kolor lakieru");
            Console.WriteLine("Q-Biały (kolor domyślny) + 0zł");
            Console.WriteLine("W-Czarny + 2000zł");
            Console.WriteLine("E-Srebrny + 3500zł");
            Console.WriteLine("R-Czerwony + 5000zł");
            //SWITCH CASE LAKIERY
            Opcje lakier = new Bialy(samochod);
            
            string opcja = Console.ReadLine();
            switch (opcja)
            {
                case "q":
                    // nowySamochod = Samochod.wybierzSamochod(TYP.SUV); funkcja która dodaje lakier
                    break;
                case "w":
                    lakier = new Czarny(samochod);
                    break;
                case "e":
                    lakier = new Srebrny(samochod);
                    break;
                case "r":
                    lakier = new Czerwony(samochod);
                    break;
                default:
                    
                    break;

            }
            return lakier;
        }
        public static Opcje wybierzAkcesoria(Opcje samochod)
        {
            Console.Clear();
            Console.WriteLine($"Obecna konfiguracja :{samochod.zwrocNazwa()}, cena:{samochod.zwrocCena()}zł");
            Console.WriteLine("Wybierz kolor lakieru");
            Console.WriteLine("Q-Opony Zimowe + 2000zł");
            Console.WriteLine("W-Bagażnik Na Rowery + 1000zł");
            Console.WriteLine("E-Podgrzewane Fotele + 3500zł");
            Console.WriteLine("R-Zakończ Dobieranie");
            //SWITCH CASE LAKIERY
            Opcje akcesoria = new Bialy(samochod);

            string opcja = Console.ReadLine();
            
            
                switch (opcja)
                {
                    case "q":
                        akcesoria = new OponyZimowe(samochod);

                        break;
                    case "w":
                        akcesoria =new BagaznikNaRowery(samochod);
                        break;
                    case "e":
                        akcesoria = new PodgrzewaneFotele(samochod);
                        break;
                    case "r":
                        break;
                    default:  
                        break;

                }

            Console.WriteLine("Czy chcesz dodać kolejne opcje Y/N ?");
            string opcja2 = Console.ReadLine();
            switch (opcja2)
            {
                case "y":
                    wybierzAkcesoria(akcesoria);
                    break;

                case "n":
                    Console.WriteLine($"Koniec konfiguracji, twoja konfiguracja to: {akcesoria.zwrocNazwa()}, cena to {akcesoria.zwrocCena()} zł");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji !!!");
                    break;
            }
            //OPONY ZIMOWE 2000ZŁ
            //BAGAŻNIK NA ROWERY 1000ZŁ
            //PODGRZEWANE FOTELE 3500ZŁ

            return akcesoria;
        }
    }
}