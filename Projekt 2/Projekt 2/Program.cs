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
            //koniec
            //Wywołanie Łańcucha ilości składników
            Lancuch l1 = new BrakDodatków();

            Lancuch l2 = new MaloDodatkow();

            Lancuch l3 = new Duzododatkow();
            int licznikdodatkowall = 0;
            
            l1.ustawNastepne(l2);

            l2.ustawNastepne(l3);
            //l1.przetwarzaj(new Liczbadodatkow(licznikdodatkowall)); wywołanie licznika dodatków
            //koniec
            
            Console.WriteLine("Zamów burgera (w)");
                Console.WriteLine("Wyjście (e)");

                string menu = Console.ReadLine();
                IBurger burger = null;
                switch (menu)
                {
                    case "w":
                        Console.Clear();
                        burger=dodajBurger();
                        stanZamowienia.ustawStan(new WybieranieReszty());
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
            #region wybieranie_burgera
            Sklad rozmiarBurgera = wybierzPieczywo(burger);//wybieranie pieczywa

            Sklad burgerZMiesem =wybierzMieso(rozmiarBurgera);//wybieranie miesa

            stanZamowienia.ustawStan(new Tworzenie());
            stanZamowienia.alert();
            Console.ReadKey();

            Sklad burgerZDodatkami = wybierzDodatki(burgerZMiesem);//wybieranie dodatkow

            stanZamowienia.ustawStan(new WybieranieReszty());
            stanZamowienia.alert();
            Console.ReadKey();

            licznikdodatkowall++;
            l1.przetwarzaj(new Liczbadodatkow(licznikdodatkowall));
            Console.ReadKey();



            Sklad burgerZSosem = wybierzSos(burgerZDodatkami);//wybieranie sosu

            licznikdodatkowall++;

            Console.Clear();
            Console.WriteLine($"Obecne zamówienie :{burgerZSosem.zwrocNazwa()}, cena:{burgerZSosem.zwrocCena()}zł");//podsumowanie
            l1.przetwarzaj(new Liczbadodatkow(licznikdodatkowall));

            stanZamowienia.ustawStan(new Zakonczenie());
            stanZamowienia.alert();

            Console.ReadKey();

            #endregion wybieranie_burgera
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

        public static Sklad wybierzPieczywo(IBurger burger)
        {   Console.Clear();//
            Console.WriteLine($"Obecne zamówienie :{burger.zwrocNazwa()}, cena:{burger.zwrocCena()}zł");//

            Console.WriteLine("Wybierz Pieczywo");
            Console.WriteLine("Q-Zwykłe");
            Console.WriteLine("W-Z Sezamem");
            Console.WriteLine("E-Z Serem");

            string opcja = Console.ReadLine();
            Sklad skladniki = new Wolowina(burger);
            switch (opcja)
            {
                case "q":
                    skladniki = new Zwykle(burger);
                    break;
                case "w":
                    skladniki = new Sezam(burger);
                    break;
                case "e":
                    skladniki = new PieczywoSer(burger);
                    break;
            }
            return skladniki;
        }

        public static Sklad wybierzMieso(IBurger burger)
        {
            Console.Clear();//
            Console.WriteLine($"Obecne zamówienie :{burger.zwrocNazwa()}, cena:{burger.zwrocCena()}zł");//
            Console.WriteLine("Wybierz Mieso");
            Console.WriteLine("Q-Z Wołowiną");
            Console.WriteLine("W-Z Kurczakiem");
            Console.WriteLine("E-Wegetariański");

            string opcja = Console.ReadLine();
            Sklad skladniki = new Wolowina(burger);
            switch (opcja)
            {
                case "q":
                    skladniki = new Wolowina(burger); 
                    break;
                case "w":
                    skladniki = new Kurczak(burger); ;
                    break;
                case "e":
                    skladniki = new Wege(burger); ;
                    break;
            }
            return skladniki;
        }

        public static Sklad wybierzDodatki(IBurger burger) 
        {
            Console.Clear();//
            Console.WriteLine($"Obecne zamówienie :{burger.zwrocNazwa()}, cena:{burger.zwrocCena()}zł");//
            Console.WriteLine("Wybierz Dodatki");
            Console.WriteLine("Q-Z pomidorem");
            Console.WriteLine("W-Z sałatą");
            Console.WriteLine("E-Z cebulą");
            Console.WriteLine("R-Bez dodatków");

            string opcja = Console.ReadLine();
            Sklad skladniki = new Wolowina(burger);
            switch (opcja)
            {
                case "q":
                    skladniki = new Pomidor(burger); 
                    break;
                case "w":
                    skladniki = new Salata(burger); 
                    break;
                case "e":
                    skladniki = new Cebula(burger); 
                    break;
            }
            return skladniki;
        }
        

        public static Sklad wybierzSos(IBurger burger)
        {
            Console.Clear();//
            Console.WriteLine($"Obecne zamówienie :{burger.zwrocNazwa()}, cena:{burger.zwrocCena()}zł");//
            Console.WriteLine("Wybierz Sos");
            Console.WriteLine("Q-BBQ");
            Console.WriteLine("W-Sos czosnkowy");
            Console.WriteLine("E-Sos teksański");

            string opcja = Console.ReadLine();
            Sklad skladniki = new Wolowina(burger);

            switch (opcja)
            {
                case "q":
                    skladniki = new BBQ(burger); ;
                    break;
                case "w":
                    skladniki = new Czosnek(burger); ;
                    break;
                case "e":
                    skladniki = new Teksanski(burger); ;
                    break;
            }
            return skladniki;
        }
        

        //wybieranie dodatkow*/


    }
}
