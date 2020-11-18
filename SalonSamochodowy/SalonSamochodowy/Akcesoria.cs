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
    abstract class Opcje:Samochod //klasa opcje za pomoca ktorej bedzie dodawane wyposarzenie dodatkowe
    {
        Samochod _samochod;
        public string _opcja;
        public decimal _cena;

        public Opcje(Samochod samochod)
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

    public class Czarny : Opcje
    {
        public Czarny(Samochod _samochod) : base(_samochod)
        {
            _name = "Czarny Lakier";
            _cena = 2000;
        }
    }
    //ZROBIC ANALOGICZNIE DLA POZOSTAŁYCH OPCJI
}
