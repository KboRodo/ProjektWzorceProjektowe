using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_2
{
    public interface Lancuch
    {
        void ustawNastepne(Lancuch c);
        void przetwarzaj(Liczbadodatkow liczbadodatkow);
    }
    public class Liczbadodatkow
    {

        private int number;

        public Liczbadodatkow(int number)
        {
            this.number = number;
        }

        public int pobierzLiczbe()
        {

            return number;
        }

    }
    public class BrakDodatków : Lancuch
    {

        private Lancuch nastepneWLancuchu;

        public void ustawNastepne(Lancuch c)
        {

            nastepneWLancuchu = c;
        }

        public void przetwarzaj(Liczbadodatkow liczbadodatkow)
        {
            if (liczbadodatkow.pobierzLiczbe() <= 0)
            {
                Console.WriteLine("Brak dodatkow w twoim burgerze");

            }
            else
            {
                nastepneWLancuchu.przetwarzaj(liczbadodatkow);

            }
        }
    }
    public class MaloDodatkow : Lancuch
    {
        private Lancuch nastepneWLancuchu;
        public void ustawNastepne(Lancuch c)
        {
            nastepneWLancuchu = c;
        }

        public void przetwarzaj(Liczbadodatkow liczbadodatkow)
        {
            if (nastepneWLancuchu != null)
            {
                if (liczbadodatkow.pobierzLiczbe() <= 1)
                {
                    Console.WriteLine("Masz w swoim burgerze mało dodatków: " + liczbadodatkow.pobierzLiczbe());
                }
                else
                {
                    ustawNastepne(new Duzododatkow());
                    nastepneWLancuchu.przetwarzaj(liczbadodatkow);
                }
            }
        }
    }

    public class Duzododatkow : Lancuch
    {
        private Lancuch nastepneWLancuchu;

        public void ustawNastepne(Lancuch c)
        {
            nastepneWLancuchu = c;
        }

        public void przetwarzaj(Liczbadodatkow liczbadodatkow)
        {
            if (nastepneWLancuchu == null)
            {
                Console.WriteLine("Masz w swoim burgerze dużo dodatków: " + liczbadodatkow.pobierzLiczbe());
            }
        }
    }

}