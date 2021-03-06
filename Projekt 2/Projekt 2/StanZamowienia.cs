﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{ //
    interface StanZamowienia
    {
        void alert();
    }
    class Powiadomienia
    {
        private StanZamowienia aktualnyStan;
        public Powiadomienia()
        {
            aktualnyStan = new Tworzenie();
        }

        public void ustawStan(StanZamowienia stan)
        {
            aktualnyStan = stan;
        }

        public void alert()
        {
            aktualnyStan.alert();
        }
    }

    class Tworzenie : StanZamowienia
    {
        public void alert()
        {
            Console.WriteLine("W trakcie wybierania...");
        }
    }
    class WybieranieReszty : StanZamowienia
    {
        public void alert()
        {
            Console.WriteLine("Twój Burger już się smaży...");
        }
    }
    class Zakonczenie : StanZamowienia
    {
        public void alert()
        {
            Console.WriteLine("Zamówienie jest gotowe do odbioru, dziękujemy za korztystanie z naszych usług");
        }
    }

}