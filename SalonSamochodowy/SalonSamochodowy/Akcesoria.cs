using System;
using System.Collections.Generic;
using System.Text;

//DEKORATOR SŁUŻĄCY DO DODAWANIA OPCJI DO SAMOCHODÓW
//DOMYSLNE- BIAŁY 0 ZŁ
//CZARNY 2000ZŁ
//SREBRNY 3500 ZŁ
//CZERWONY 5000 ZŁ
//OPONY ZIMOWE 2000ZŁ
//BAGAŻNIK NA ROWERY 1000ZŁ
//PODGRZEWANE FOTELE 3500ZŁ

//ROZBIC NA 2 MENU
//1. KOLOR LAKIERU
//2. WYPOSARZENIE DODATKOWE

namespace SalonSamochodowy
{
    public abstract class Opcje:Parametry //klasa opcje za pomoca ktorej bedzie dodawane wyposarzenie dodatkowe
    {
        Parametry _samochod;
        public string _opcja;
        public decimal _cena;

        public Opcje(Parametry samochod)
        {
            _samochod = samochod;
        }
        public string zwrocNazwa()
        {
            return string.Format("{0},{1}", _samochod.zwrocNazwa(), _opcja);
        }
        public decimal zwrocCena()
        {
            return (_samochod.zwrocCena() + _cena);
        }

    }
    public class Bialy : Opcje
    {
        public Bialy(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Bialy Lakier";
            _cena = 0;
        }
    }
    public class Czarny : Opcje
    {
        public Czarny(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Czarny Lakier";
            _cena = 2000;
        }
    }
    public class Srebrny : Opcje
    {
        public Srebrny(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Srebrny Lakier";
            _cena = 3500;
        }
    }
    public class Czerwony: Opcje
    {
        public Czerwony(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Czerwony Lakier";
            _cena = 5000;
        }
    }
    public class OponyZimowe : Opcje
    {
        public OponyZimowe(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Opony Zimowe";
            _cena = 2000;
        }
    }
    public class BagaznikNaRowery : Opcje
    {
        public BagaznikNaRowery(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Bagażnik Na Rowery";
            _cena = 1000;
        }
    }
    public class PodgrzewaneFotele : Opcje
    {
        public PodgrzewaneFotele(Parametry _samochod) : base(_samochod)
        {
            _opcja = " Podgrzewane Fotele";
            _cena = 3500;
        }
    }

}
